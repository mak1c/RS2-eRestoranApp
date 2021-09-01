using eRestoran.Mobile.ViewModels;
using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRestoran.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProizvodDetaljiPage : ContentPage
    {
        ProizvodDetaljiViewModel model = null;
        public ProizvodDetaljiPage(Proizvodi proizvod)
        {
            InitializeComponent();
            BindingContext = model = new ProizvodDetaljiViewModel() {
                Proizvod = proizvod
            };
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            model.InitCommand.Execute(null);
            await model.Recommender();
        }
        private async void recommendedArticlesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var article = e.SelectedItem as Model.Proizvodi;
            await Navigation.PushAsync(new ProizvodDetaljiPage(article));
        }
    }
}