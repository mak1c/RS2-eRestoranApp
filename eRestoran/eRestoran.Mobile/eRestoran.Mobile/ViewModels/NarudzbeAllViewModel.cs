using eRestoran.Mobile.Models;
using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class NarudzbeAllViewModel : BaseViewModel
    {
        private APIService _service = new APIService("Narudzbe");
        public NarudzbeAllViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Narudzbe> NarudzbeList { get; set; } = new ObservableCollection<Narudzbe>();
        public ObservableCollection<NarudzbeA> NarudzbeListA { get; set; } = new ObservableCollection<NarudzbeA>();



        
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            NarudzbeSearchRequest trazi = new NarudzbeSearchRequest();
            trazi.KorisnikId = APIService.Id;
            var list = await _service.Get<IEnumerable<Narudzbe>>(trazi);
            //list.OrderByDescending(x => x.NarudzbeId);
            NarudzbeListA.Clear();
            foreach (var narudzba in list)
            {
                NarudzbeA nova = new NarudzbeA();
                nova.Adresa = narudzba.Adresa;
                nova.BrojTelefona = narudzba.BrojTelefona;
                nova.NarudzbeId = narudzba.NarudzbeId;
                nova.Korisnik = narudzba.Korisnik;
                nova.ZaUplatit = narudzba.ZaUplatiti;
                nova.DatumNarudžbe = narudzba.DatumNarudžbe;
                nova.NarudzbaStatus = narudzba.NarudzbaStatus;
                
                if (narudzba.Placena==true)
                {
                    nova.PlacenaBool = true;
                    nova.Placena = "Plaćeno";
                }
                else
                {
                    nova.Placena = "Nije plaćeno";
                    nova.PlacenaBool = false;
                }
                if (narudzba.NarudzbaStatusId == 1)
                {
                    nova.BojaStatusa= "Orange";
                }
                else if (narudzba.NarudzbaStatusId == 2)
                {
                    nova.BojaStatusa = "Mediumslateblue";
                }
                else if (narudzba.NarudzbaStatusId == 3)
                {
                    nova.BojaStatusa = "Green";
                }
                else
                {
                    nova.BojaStatusa = "Red";
                }
                nova.KorisnikId = narudzba.KorisnikId;
              
                NarudzbeListA.Add(nova);
                
            }
        }
    }
}
