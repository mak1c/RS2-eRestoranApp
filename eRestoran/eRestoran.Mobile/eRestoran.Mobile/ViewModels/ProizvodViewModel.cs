using eRestoran.Model;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.Mobile.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvodi");
        private readonly APIService _kategorijeService = new APIService("Kategorija");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
    
        }
        public ObservableCollection<Proizvodi> ProizvodiList { get; set; } = new ObservableCollection<Proizvodi>();
        public ObservableCollection<Kategorija> KategorijaProizvodaList { get; set; } = new ObservableCollection<Kategorija>();

        Kategorija _selectedKategorijaProizvoda = null;


       

        public Kategorija SelectedKategorijaProizvoda
        {
            get { return _selectedKategorijaProizvoda; }
            set
            {
                SetProperty(ref _selectedKategorijaProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (KategorijaProizvodaList.Count == 0)
            {
                var vrsteProizvodaList = await _kategorijeService.Get<List<Kategorija>>(null);

                foreach (var vrsteProizvoda in vrsteProizvodaList)
                {
                    KategorijaProizvodaList.Add(vrsteProizvoda);
                }
                var list = await _proizvodiService.Get<IEnumerable<Proizvodi>>(null);

                ProizvodiList.Clear();
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
  
                }
            }

            if (SelectedKategorijaProizvoda != null)
            {
                ProizvodiSearchRequest search = new ProizvodiSearchRequest();
                search.KategorijaId = SelectedKategorijaProizvoda.KategorijaId;
                //search.Naziv = "";
                var list = await _proizvodiService.Get<IEnumerable<Proizvodi>>(search);

                ProizvodiList.Clear();
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
                    //}
                }


            }
        }



        
    }
}