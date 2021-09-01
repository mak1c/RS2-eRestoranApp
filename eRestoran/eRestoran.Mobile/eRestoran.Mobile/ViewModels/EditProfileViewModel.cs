using eRestoran.Mobile.Views;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    class EditProfileViewModel : BaseViewModel
    {

        private APIService _korisnikService = new APIService("Korisnici");
        public EditProfileViewModel()
        {
            SpremiCommand = new Command(async () => { await Spremi(); });
            InitCommand = new Command(Init);
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }


        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _passwordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }




        public ICommand InitCommand { get; set; }
        public async void Init()
        {
            var entity = await _korisnikService.GetById<Model.Korisnici>(APIService.Id);
            if (entity!=null)
            {
                Ime = entity.Ime;

                Prezime = entity.Prezime;

                Email = entity.Email;

                Telefon = entity.Telefon;

                Username = entity.KorisnickoIme;

            }
        }


        public ICommand SpremiCommand { get; set; }
        async Task Spremi()
        {
            IsBusy = true;

            if (string.IsNullOrWhiteSpace(Ime))
            {
                await Application.Current.MainPage.DisplayAlert("", "Ime je obavezno!", "OK");
                return;
            }
            else if (!Regex.Match(Ime, @"^[a-zA-ZČčĆćŽžĐđŠš ]+$", RegexOptions.IgnoreCase).Success)
            {
                await Application.Current.MainPage.DisplayAlert("", "Dovoljena su samo slova!", "OK");
                return;

            }
            else if (Ime.Length > 50)
            {
                await Application.Current.MainPage.DisplayAlert("", "Makismalna dozvoljena duzina imena je 50 karaktera!", "OK");
                return;

            }
            if (string.IsNullOrWhiteSpace(Prezime))
            {
                await Application.Current.MainPage.DisplayAlert("", "Prezime je obavezno!", "OK");
                return;
            }
            else if (!Regex.Match(Prezime, @"^[a-zA-ZČčĆćŽžĐđŠš ]+$", RegexOptions.IgnoreCase).Success)
            {
                await Application.Current.MainPage.DisplayAlert("", "Dovoljena su samo slova!", "OK");
                return;

            }
            else if (Prezime.Length > 50)
            {
                await Application.Current.MainPage.DisplayAlert("", "Makismalna dozvoljena duzina prezimena je 50 karaktera!", "OK");
                return;

            }

            //if (string.IsNullOrWhiteSpace(Email))
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Email je obavezan!", "OK");
            //    return;
            //}
            //if (!Regex.Match(Email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase).Success)
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Neispravan format email-a!", "OK");
            //    return;
            //}
            //KorisniciSearchRequest emailrequest = new KorisniciSearchRequest
            //{
            //    Email = Email
            //};
            //List<Model.Korisnici> korisnik = await _korisnikService.Get<List<Model.Korisnici>>(emailrequest);
            //if (korisnik.Count > 0)
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Email je već registrovan!", "OK");
            //    return;
            //}
            //if (Telefon != "" && !Regex.Match(Telefon, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Telefon: Dozvoljeni su samo brojevi!", "OK");
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(Username))
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Username je obavezan!", "OK");
            //    return;
            //}
            //KorisniciSearchRequest usernamerequest = new KorisniciSearchRequest
            //{
            //    KorisnickoIme = Username
            //};
            //korisnik = await _korisnikService.Get<List<Model.Korisnici>>(usernamerequest);
            //if (korisnik.Count > 0)
            //{
            //    await Application.Current.MainPage.DisplayAlert("", "Username već postoji!", "OK");
            //    return;
            //}
            if (!string.IsNullOrEmpty(Password))
            {
                if (Password != PasswordConfirmation)
                {
                    await Application.Current.MainPage.DisplayAlert("", "Passwordi se ne slazu!", "OK");
                    return;
                }
            }

           

           
            Model.Requests.KorisniciUpdateRequest request = new Model.Requests.KorisniciUpdateRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                PasswordPotvrda = PasswordConfirmation,

                Email = Email,
                Telefon = Telefon,
                UlogaId = 3,
                Slika = null,
                //Status = true,
                KorisnickoIme = Username,
                Password = Password
            };
            //if (request.Password != "" && request.Password == request.PasswordPotvrda)
            //{
            //    APIService.Password = request.Password;
            //}
            var entity = await _korisnikService.Update<Model.Korisnici>(APIService.Id,request);
            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("", "Uspjesno ste izmjenili profil", "OK");
                if (request.Password!="")
                {
                    APIService.Password = request.Password;
                }
            }
            //await Application.Current.MainPage.DisplayAlert("", "Uspjesno ste se registrovali!", "OK");
        //    Application.Current.MainPage = new MainPage();
        //}
    }
}


    }

