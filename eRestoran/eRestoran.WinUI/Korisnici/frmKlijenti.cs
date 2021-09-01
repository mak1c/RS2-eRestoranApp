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

namespace eRestoran.WinUI.Korisnici
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _apiServiceKlijenti = new APIService("Korisnici");
        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void LoadKlijente()
        {
            
            var search = new KorisniciSearchRequest()
            {
      
                UlogaId = 3
            };
            if (!String.IsNullOrWhiteSpace(txtIme.Text))
            {
                search.Ime = txtIme.Text;
            }
            if (!String.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                search.Prezime = txtPrezime.Text;
            }
            var result = await _apiServiceKlijenti.Get<List<Model.Korisnici>>(search);
            dgv_klijenti.AutoGenerateColumns = false;
            dgv_klijenti.DataSource = result;
        }

        private async void btnPretragaKlijenata_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                UlogaId = 3
            };
            var result = await _apiServiceKlijenti.Get<List<Model.Korisnici>>(search);
            dgv_klijenti.AutoGenerateColumns = false;
            dgv_klijenti.DataSource = result;
        }

        private async void dgv_klijenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = Int32.Parse(dgv_klijenti.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var korisnik = await _apiServiceKlijenti.GetById<Model.Korisnici>(_id);
            bool statusbio = korisnik.Status;
            if (e.ColumnIndex == 6)
            {

                

                KorisniciUpdateRequest req = new KorisniciUpdateRequest();
                if (statusbio)
                {
                    req.Status = false;
                }
                else
                {
                    req.Status = true;
                }
                req.Slika = korisnik.Slika;
                req.KorisnickoIme = korisnik.KorisnickoIme;
                req.Email = korisnik.Email;
                req.Telefon = korisnik.Telefon;
                req.Ime = korisnik.Ime;
                req.Prezime = korisnik.Prezime;
                req.UlogaId = 3;
                var entity = await _apiServiceKlijenti.Update<Model.Korisnici>(_id, req);
                if (entity != null&& statusbio)
                {
                    MessageBox.Show("Korisnik je isključen");
                }
                if (entity != null && !statusbio)
                {
                    MessageBox.Show("Korisnik je uključen");
                }
                LoadKlijente();
            }
            if (e.ColumnIndex == 7)
            {
                //int _id = Int32.Parse(dgv_klijenti.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                KorisniciUpdateRequest req = new KorisniciUpdateRequest();
                req.Status = false;
               
                var entity=await _apiServiceKlijenti.Update<Model.Korisnici>(_id,req);
                if (entity!=null)
                {
                    MessageBox.Show("Korisnik je isključen");
                }
                LoadKlijente();
            }
        }

        private  void frmKlijenti_Load(object sender, EventArgs e)
        {
             LoadKlijente();
        }
    }
}
