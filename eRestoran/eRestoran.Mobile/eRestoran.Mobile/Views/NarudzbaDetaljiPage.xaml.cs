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
    public partial class NarudzbaDetaljiPage : ContentPage
    {
        NarudzbaDetaljiViewModel model = null;
        public NarudzbaDetaljiPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, true);
        }
        public NarudzbaDetaljiPage(NarudzbeA narudzba)
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaDetaljiViewModel(Navigation)
            {
                Narudzba = narudzba,
            };
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, true);

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }


    }
}