using eRestoran.Mobile.Views;
using eRestoran.Mobile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using eRestoran.Model.Requests;
using System.Linq;
using System.Text.RegularExpressions;

namespace eRestoran.Mobile.ViewModels
{
   public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        public LoginViewModel()
        {
            LoginCommand = new Command(async() =>  await Login());

            RegisterCommand = new Command(() =>
            {
                Application.Current.MainPage = new RegistracijaPage();
            });
        }
        public ICommand RegisterCommand { get; set; }


        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }

        public ICommand LoginCommand { get; set; }

        //bool IsBusy = false;
        async Task Login()
        {
            if (Username == "")
            {
                await Application.Current.MainPage.DisplayAlert("", "Ime: je obavezno!", "OK");
                return;
            }
           else if (Lozinka == "")
            {
                await Application.Current.MainPage.DisplayAlert("", "Lozinka: je obavezna!", "OK");
                return;
            }

            try
            {
                IsBusy = true;

                APIService.Username = Username;
                APIService.Password = Lozinka;
                await _service.Get<dynamic>(null);
         
                KorisniciSearchRequest request = new KorisniciSearchRequest { KorisnickoIme = Username };
                List<Model.Korisnici> korisnici = await _service.Get<List<Model.Korisnici>>(request);
                APIService.Id = korisnici.Where(x => x.KorisnickoIme == APIService.Username).Select(x => x.KorisnikId).SingleOrDefault();
                APIService.Rola = korisnici.Where(x => x.KorisnickoIme == APIService.Username).Select(x => x.UlogaId).SingleOrDefault();

                Application.Current.MainPage = new MainPage();
               

               
            }
            catch (Exception)
            {
                
            }
        }
    }
}
