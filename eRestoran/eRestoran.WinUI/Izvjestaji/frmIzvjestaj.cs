using eRestoran.Model;
using eRestoran.Model.Requests;
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
    public partial class frmIzvjestaj : Form
    {
        private readonly APIService _narudzbaProizvod = new APIService("NarudzbaProizvod");
        private readonly APIService _proizvodi = new APIService("Proizvodi");
        private readonly APIService _narudzbe = new APIService("Narudzbe");
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lblUcitavam.Text = "Učitavam...";
            double _ukupnaZarada = 0;
            List<Model.Proizvodi> proizvodiList = await _proizvodi.Get<List<Model.Proizvodi>>(null);
            List<Model.IzvjestajNarudzbaProizvod> izvjestajNarudzbaProizvodList = new List<IzvjestajNarudzbaProizvod>();
            List<Model.Narudzbe> NarudzbaList = await _narudzbe.Get<List<Model.Narudzbe>>(null);
            foreach (var x in proizvodiList)
            {
                double _zarada = 0;
                int _brojProdanih = 0;
                foreach (var item in NarudzbaList)
                {
                    if (item.DatumNarudžbe.Date > dateTimePicker1.Value && item.DatumNarudžbe.Date < dateTimePicker2.Value)
                    {
                        NarudzbaProizvodSearchRequest request = new NarudzbaProizvodSearchRequest { ProizvodId = x.ProizvodId, NarudzbaId = item.NarudzbeId };
                        List<Model.NarudzbaProizvod> NarudzbaProizvodList = await _narudzbaProizvod.Get<List<NarudzbaProizvod>>(request);

                        foreach (var y in NarudzbaProizvodList)
                        {


                            _ukupnaZarada += y.Ukupno;
                            _zarada += y.Ukupno;
                            _brojProdanih += y.Kolicina;

                        }
                       

                    }
                }
                if (_brojProdanih > 0)
                {
                    Model.IzvjestajNarudzbaProizvod izvjestajPlan = new IzvjestajNarudzbaProizvod
                    {
                        Naziv = x.Naziv,
                        UkupnaZarada = _zarada,
                        BrojProdanih = _brojProdanih
                    };


                    izvjestajNarudzbaProizvodList.Add(izvjestajPlan);
                }




            }

           
            List<Model.IzvjestajNarudzbaProizvod> izvjestajNarudzbaProizvodList2 = new List<IzvjestajNarudzbaProizvod>();
         
            label4.Text = _ukupnaZarada.ToString() + " KM";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = izvjestajNarudzbaProizvodList;
            lblUcitavam.Text = "";
        }

        private void btnMjesecni_Click(object sender, EventArgs e)
        {
            frmIzvjestajKategorijeProizvodi frm = new frmIzvjestajKategorijeProizvodi();
            frm.Show();

        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.AddMonths(-2);
        }
    }
}
