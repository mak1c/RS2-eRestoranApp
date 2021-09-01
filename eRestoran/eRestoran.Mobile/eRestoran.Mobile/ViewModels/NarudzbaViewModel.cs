using eRestoran.Mobile.Views;
using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class NarudzbaViewModel:BaseViewModel
    {

        private APIService _service = new APIService("Narudzbe");
        private APIService _serviceN = new APIService("NarudzbaProizvod");
        private APIService _serviceK = new APIService("Korisnici");
        public INavigation Navigation { get; set; }
        public NarudzbaViewModel()
        {
            //this.Navigation = navigation;
            //ZavrsiCommand = new Command(ZavrsiNarudzbu);
            ZavrsiCommand = new Command(async () => await ZavrsiNarudzbu());
            OcistiCommand = new Command(Ocisti);
        }
        public NarudzbaViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            ZavrsiCommand = new Command(async () => await ZavrsiNarudzbu());
            OcistiCommand = new Command(Ocisti);

        }
        decimal _UkupnoZaPlatiti = 0;
        public decimal UkupnoZaPlatiti
        {
            get { return _UkupnoZaPlatiti; }
            set
            {
                SetProperty(ref _UkupnoZaPlatiti, value);
            }
        }
        //decimal _cijenaa = 0;
        private void IzracunajUkupno()
        {
            _UkupnoZaPlatiti = 0;
            foreach (var item in CartService.Cart)
            {
                UkupnoZaPlatiti += item.Value.Kolicina * item.Value.Proizvod.Cijena;
            }
        }
        string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }
        public ObservableCollection<ProizvodDetaljiViewModel> NarudzbaList { get; set; } = new ObservableCollection<ProizvodDetaljiViewModel>();

        public void Init()
        {
            
            NarudzbaList.Clear();

            foreach (var cartValue in CartService.Cart.Values)
            {
                NarudzbaList.Add(cartValue);
            }
            IzracunajUkupno();
        }

        public ICommand OcistiCommand { get; set; }
        private void Ocisti()
        {

            CartService.Cart.Clear();
            Adresa= "";
            UkupnoZaPlatiti = 0;
            Init();
           
        }
        public ICommand ZavrsiCommand { get; set; }
        async Task ZavrsiNarudzbu()
        {
            int BrojArtikala = 0;
            foreach (var item in CartService.Cart)
            {
                BrojArtikala++;
            }
            if (BrojArtikala == 0)
            {
                await Application.Current.MainPage.DisplayAlert("", "Prazna korpa!", "OK");
                return;
            }
            if (Adresa == "")
            {
                await Application.Current.MainPage.DisplayAlert("", "Adresa je obavezna!", "OK");
                return;
            }
            else if (Adresa.Length<5)
            {
                await Application.Current.MainPage.DisplayAlert("", "Minimalno je 5 znakova!", "OK");
                return;

            }
          
       
            var k = await _serviceK.GetById<Model.Korisnici>(APIService.Id);
            //await _obavijestiService.Get<IEnumerable<Obavijest>>(null);
            NarudzbaUpsertRequest nova = new NarudzbaUpsertRequest();
            //Izracunaj();
            bool ImaProizvode = false;
            nova.KorisnikId = APIService.Id;
            nova.DatumNarudžbe = DateTime.Now;
            nova.Adresa = Adresa;
            nova.ZaUplatiti = UkupnoZaPlatiti;
            nova.NarudzbaStatusId = 0;
            nova.Placena = false;
            nova.BrojTelefona = k.Telefon;
            var entity = await _service.Insert<Model.Narudzbe>(nova);
            if (entity != null)
            {
                foreach (var item in CartService.Cart)
                {
                    NarudzbaProizvodUpsertRequest novi = new NarudzbaProizvodUpsertRequest();
                    novi.Cijena = (double)item.Value.Cijenaa;
                    novi.Kolicina = (int)item.Value.Kolicina;
                    novi.NarudzbeId = entity.NarudzbeId;
                    novi.ProizvodId = item.Value.Proizvod.ProizvodId;
                    var entity1 = await _serviceN.Insert<Model.NarudzbaProizvod>(novi);
                    ImaProizvode = true;
                }
                await App.Current.MainPage.DisplayAlert("Success", "Uspješno dodana narudžba", "OK");
                if (ImaProizvode)
                {
                    await Navigation.PushAsync(new StripePaymentGatewayPage(UkupnoZaPlatiti, entity.NarudzbeId));
                }
                Ocisti();

            }
        }

    }
   
}
