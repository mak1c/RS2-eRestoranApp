using eRestoran.Mobile.ViewModels;
using eRestoran.Model.Requests;
using Stripe;
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
    public partial class NarudzbaPage : ContentPage
    {
        private APIService _service = new APIService("Narudzbe");
        private APIService _serviceN = new APIService("NarudzbaProizvod");
        private APIService _serviceK = new APIService("Korisnici");
        decimal ukupnaCijena = 0;
        private NarudzbaViewModel model = null;
        //public Token stripeToken;
        //public TokenService TokenService;
        public NarudzbaPage()
        {
            InitializeComponent();
          BindingContext=  model  = new NarudzbaViewModel(Navigation);
           
        }

        private decimal Izracunaj()
        {
            foreach (var item in CartService.Cart)
            {
                ukupnaCijena = item.Value.Kolicina;
            }
            return 6;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        //private async void Finish_Clicked(object sender, EventArgs e)
        //{
            
        //    var k = await _serviceK.GetById<Model.Korisnici>(APIService.Id);
        //    //await _obavijestiService.Get<IEnumerable<Obavijest>>(null);
        //    NarudzbaUpsertRequest nova = new NarudzbaUpsertRequest();
        //    Izracunaj();
        //    bool ImaProizvode = false;
        //    nova.KorisnikId = APIService.Id;
        //    nova.DatumNarudžbe = DateTime.Now;
        //    nova.Adresa = model.Adresa;
        //    nova.NarudzbaStatusId = 0;
        //    nova.Placena = false;
        //    nova.BrojTelefona = k.Telefon;
        //    var entity = await _service.Insert<Model.Narudzbe>(nova);
        //    if (entity != null)
        //    {
        //        foreach (var item in CartService.Cart)
        //        {
        //            NarudzbaProizvodUpsertRequest novi = new NarudzbaProizvodUpsertRequest();
        //            novi.Cijena = (double)item.Value.Cijenaa;
        //            novi.Kolicina = (int)item.Value.Kolicina;
        //            novi.NarudzbeId = entity.NarudzbeId;
        //            novi.ProizvodId = item.Value.Proizvod.ProizvodId;
        //            var entity1 = await _serviceN.Insert<Model.NarudzbaProizvod>(novi);
        //            ImaProizvode = true;
        //        }

        //        //if (ImaProizvode)
        //        //{
        //        //    await Navigation.PushAsync(new StripePaymentGatewayPage(model.Value));
        //        //}
        //       //model.OcistiCommand();
        //    }
        //}
        //public bool MakePayment(string token);
       
    }
}