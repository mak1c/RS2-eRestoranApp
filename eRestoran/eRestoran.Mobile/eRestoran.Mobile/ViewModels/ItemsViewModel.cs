using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using eRestoran.Mobile.Models;
using eRestoran.Mobile.Views;
using eRestoran.Model;
using System.Windows.Input;

namespace eRestoran.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
  
        private readonly APIService _service = new APIService("Informacije");



        public ItemsViewModel()
        {
            Title = "eRestoran";
   
            InfoCommand =new Command(Init);
        



        }


        string _Naziv;
        public string Naziv
        {
            get { return _Naziv; }
            set
            {
                SetProperty(ref _Naziv, value);
            }
        }
        string _Adresa = "a";
        public string Adresa
        {
            get { return _Adresa; }
            set
            {
                SetProperty(ref _Adresa, value);
            }
        }
        string _Telefon = "";
        public string Telefon
        {
            get { return _Telefon; }
            set
            {
                SetProperty(ref _Telefon, value);
            }
        }
        DateTime _RadimoOd;
        public DateTime RadimoOd
        {
            get { return _RadimoOd; }
            set
            {
                SetProperty(ref _RadimoOd, value);
            }
        }
        DateTime _RadimoDo;
        public DateTime RadimoDo
        {
            get { return _RadimoDo; }
            set
            {
                SetProperty(ref _RadimoDo, value);
            }
        }
        byte[] _Slika;
        public byte[] Slika
        {
            get { return _Slika; }
            set
            {
                SetProperty(ref _Slika, value);
            }
        }


        string _radnodo;
        public string radnodo
        {
            get { return _radnodo; }
            set
            {
                SetProperty(ref _radnodo, value);
            }
        }

        public Informacije Info;



        public async void Init()
        {
            try
            {
                var entity = await _service.GetById<Model.Informacije>(1);
                if (entity != null)
                {
                    Info = new Informacije();
                    Info = entity;
                    Naziv = entity.NazivObjekta;
                    Adresa = entity.Lokacija;
                    Telefon = entity.BrojTelefona;
                    RadimoOd = entity.RadimoOd;
                    Slika = entity.Slika;
                    RadimoDo = entity.RadimoDo;
                }
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("", "Nisi autentificiran!", "OK");
               
            }
          
        }
       

        public ICommand InfoCommand;

       
    }
}