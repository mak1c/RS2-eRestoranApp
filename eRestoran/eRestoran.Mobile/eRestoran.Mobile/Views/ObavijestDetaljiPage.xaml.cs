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
    public partial class ObavijestDetaljiPage : ContentPage
    {
        ObavijestDetaljiViewModel model = null;
        public ObavijestDetaljiPage(Obavijest obavijest)
        {
            InitializeComponent();
            BindingContext = model = new ObavijestDetaljiViewModel()
            {
                Obavijest = obavijest
            };
        }
    }
}