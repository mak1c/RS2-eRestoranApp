using eRestoran.Mobile.Models;
using eRestoran.Mobile.Views;
using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
   public class NarudzbaDetaljiViewModel:BaseViewModel
    {

        private APIService _service = new APIService("Narudzbe");
        private APIService _serviceP = new APIService("Proizvodi");
        private APIService _serviceN = new APIService("NarudzbaProizvod");
        private APIService _serviceK = new APIService("Korisnici");
        public INavigation Navigation { get; set; }
        public NarudzbaDetaljiViewModel()
        {

            PlatiCommand = new Command(Plati);
        }
        public NarudzbaDetaljiViewModel(INavigation navigation)
        {
            Navigation = navigation;
            PlatiCommand = new Command(Plati);
        }
        public NarudzbeA Narudzba { get; set; }
  
       
        public ObservableCollection<NarudzbaItem> ProizvodiList { get; set; } = new ObservableCollection<NarudzbaItem>();

        public async void Init()
        {

            ProizvodiList.Clear();
            NarudzbaProizvodSearchRequest req = new NarudzbaProizvodSearchRequest();

            req.NarudzbaId = Narudzba.NarudzbeId;
            var Narudzbaproizvod = await _serviceN.Get<List<NarudzbaProizvod>>(req);
            //var proizvodi = await _serviceP.Get<List<Proizvodi>>(null);
            foreach (var item in Narudzbaproizvod)
            {
               
                Proizvodi proizvod = await _serviceP.GetById<Proizvodi>(item.ProizvodId);
                

                NarudzbaItem novi = new NarudzbaItem()
                {
                    Proizvod = proizvod,
                    Cijena = item.Cijena,
                    Kolicina=item.Kolicina
                };
                ProizvodiList.Add(novi);
            }
    
        }

       
       
        public ICommand PlatiCommand { get; set; }
        private async void Plati()
        {

            var k = await _serviceK.GetById<Model.Korisnici>(APIService.Id);
            if (Narudzba.PlacenaBool)
            {
                await App.Current.MainPage.DisplayAlert("Upozorenje", "Ne možete dva puta platiti istu narudžbu!", "OK");
            }
            else
            {
                await Navigation.PushAsync(new StripePaymentGatewayPage(Narudzba.ZaUplatit, Narudzba.NarudzbeId));

            }



        }
        }

    }



