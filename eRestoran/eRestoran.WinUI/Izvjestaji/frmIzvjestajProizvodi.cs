using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Izvjestaji
{
    public partial class frmIzvjestajKategorijeProizvodi : Form
    {
        public frmIzvjestajKategorijeProizvodi()
        {
            InitializeComponent();
        
        }
        private readonly APIService _narudzbaProizvod = new APIService("NarudzbaProizvod");
        private readonly APIService _proizvodi = new APIService("Proizvodi");
        private readonly APIService _narudzbe = new APIService("Narudzbe");

        public class IzvjestajVM
        {
            public BindingList<MjesecUkupnoIzvjestaj> IzvjestajPoMjesecima { get; set; }
        }
        public async Task UcitajIzvjestaj()
        {
        
        List<string> mjeseci = new List<string> { "JANUAR", "FEBRUAR", "MART", "APRIL", "MAJ", "JUNI", "JULI", "AUGUST", "SEPTEMBAR", "OKTOBAR", "NOVEMBAR", "DECEMBAR" };
                List<MjesecUkupnoIzvjestaj> UkupnoPoMjesecu = new List<MjesecUkupnoIzvjestaj>();
                IzvjestajVM model = new IzvjestajVM();
                int _ukupnonarudzbi = 0;
                var entity = await _narudzbe.Get<IEnumerable<Model.Narudzbe>>(null);

                _ukupnonarudzbi = entity.Count();
                    model.IzvjestajPoMjesecima = new BindingList<MjesecUkupnoIzvjestaj>();
                    int ukupnoprodato = 0;
                    
            decimal ukupnozaradjeno = 0;
                    for (int i = 0; i< 12; i++)
                    {
                        int brojprodatih = 0;
            MjesecUkupnoIzvjestaj mjesecNovi = new MjesecUkupnoIzvjestaj();
            mjesecNovi.MjesecBroj = i + 1;
                        mjesecNovi.MjesecNaziv = mjeseci[i];

                        decimal MjesecSuma = 0;
                        foreach (var item in entity)
                        {
                            if (Convert.ToInt32(item.DatumNarudžbe.Month)==Convert.ToInt32(i+1))
                            {
                                brojprodatih++;
                                MjesecSuma += item.ZaUplatiti;
                            }
                        }
                        mjesecNovi.MjesecBrojProdatih = brojprodatih;
                        mjesecNovi.MjesecUkupno = MjesecSuma;
                        UkupnoPoMjesecu.Add(mjesecNovi);
                        model.IzvjestajPoMjesecima.Add(mjesecNovi);
                        brojprodatih = 0;
                       MjesecSuma = 0;

                 
                }
      
            var source = new BindingSource(model.IzvjestajPoMjesecima, null);
          
            dgvMjesecIzvjestaj.AutoGenerateColumns = false;
            dgvMjesecIzvjestaj.DataSource = source;
            string najvecimjnarudzbe = "";
            int najvisenarudzbi = 0;
            string najvecimjprofit = "";
            decimal najviseprofit = 0;
            foreach (var item in model.IzvjestajPoMjesecima)
            {
                if (item.MjesecBrojProdatih> najvisenarudzbi)
                {
                    najvisenarudzbi = item.MjesecBrojProdatih;
                    najvecimjnarudzbe = item.MjesecNaziv;
                }
                if (item.MjesecUkupno > najviseprofit)
                {
                    najviseprofit = item.MjesecUkupno;
                    najvecimjprofit = item.MjesecNaziv;
                }
            }
            lblnajvise.Text =najvecimjnarudzbe+ " - " + najvisenarudzbi.ToString() +" narudžbi";
            lblnajveci.Text = najvecimjprofit + " - " + najviseprofit.ToString() + " KM";
        }

        private void frmIzvjestajKategorijeProizvodi_Load(object sender, EventArgs e)
        {
            UcitajIzvjestaj();
        }
    }

}

