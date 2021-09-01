using eRestoran.Mobile.Models;
using eRestoran.Mobile.ViewModels;
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
    
    public partial class NarudzbeAllPage : ContentPage
    {
        NarudzbeAllViewModel model = new NarudzbeAllViewModel();
        public NarudzbeAllPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbeAllViewModel();
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as NarudzbeA;
            //await Navigation.PushAsync(new NavigationPage(new NarudzbaDetaljiPage(item)));
           await Navigation.PushAsync(new NarudzbaDetaljiPage(item));
        }
    }

   
}