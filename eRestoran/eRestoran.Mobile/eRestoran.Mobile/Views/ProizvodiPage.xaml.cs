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
    public partial class ProizvodiPage : ContentPage
    {
        private ProizvodiViewModel model = null;
     
        public ProizvodiPage()
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Proizvodi;
            Navigation.PushAsync(new ProizvodDetaljiPage(item));
        }
       
    }
}