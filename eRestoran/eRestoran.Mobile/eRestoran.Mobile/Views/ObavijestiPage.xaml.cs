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
    public partial class ObavijestiPage : ContentPage
    {
        private ObavijestiViewModel model = null;
        public ObavijestiPage()
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Obavijest;
           await  Navigation.PushAsync(new ObavijestDetaljiPage(item));
            //await Navigation.PushModalAsync(new NavigationPage(new ObavijestDetaljiPage(item)));

            //async void AddItem_Clicked(object sender, EventArgs e)
            //{
            //    await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
            //}
        }
    }
}