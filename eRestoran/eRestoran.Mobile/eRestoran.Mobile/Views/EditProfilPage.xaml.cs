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
    public partial class EditProfilPage : ContentPage
    {

        EditProfileViewModel model;
        public EditProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new EditProfileViewModel();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
           
        }
    }
}