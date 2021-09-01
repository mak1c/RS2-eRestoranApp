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

namespace eRestoran.WinUI.Narudzbe
{
    public partial class frmNarudzbaDetalji : Form
    {
        private readonly APIService _narudzbe = new APIService("Narudzbe");
        private readonly APIService _narudzbeS = new APIService("NarudzbaStatus");
        private readonly APIService _narudzbeP = new APIService("NarudzbaProizvod");
        int? NarudzbaID = null;
       
        public frmNarudzbaDetalji(int? narudzbaID = null)
        {
            InitializeComponent();
            NarudzbaID = narudzbaID;
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadProizvodi()
        {

            NarudzbaProizvodSearchRequest request = new NarudzbaProizvodSearchRequest();
            request.NarudzbaId = NarudzbaID;
            var result = await _narudzbeP.Get<List<Model.NarudzbaProizvod>>(request);
            dgvNarudzbaProizvodiV.AutoGenerateColumns = false;
            dgvNarudzbaProizvodiV.DataSource = result;
            int sum = 0;
 
            foreach (DataGridViewRow row in dgvNarudzbaProizvodiV.Rows)
            {
                sum += Convert.ToInt32(row.Cells["UkupnoPoProizvodu"].Value);

            }
            lblUkupno.Text = sum.ToString();
        }
        private async Task UcitajNarudzbu()
        {
          
            var narudzba = await _narudzbe.GetById<Model.Narudzbe>(NarudzbaID);
            var status = await _narudzbeS.GetById<Model.NarudzbaStatus>(narudzba.NarudzbaStatusId);
            lblIme.Text = narudzba.Korisnik;
            lblVrijeme.Text = narudzba.DatumNarudžbe.ToLongDateString();
            lblStatus.Text = status.Status;
            lblAdresa.Text = narudzba.Adresa;
            if (narudzba.Placena)
            {
                txtPlacenoo.Text = "ID UPLATE:";
                txtPaymentId.Text = narudzba.PaymentId;
            }
            lblBrojTelefona.Text = narudzba.BrojTelefona;
           
            if (narudzba.NarudzbaStatusId==4)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                btnOdbij.Hide();
                btnPrihvati.Hide();
                btnZavrsi.Hide();

            }
            else if (narudzba.NarudzbaStatusId == 3)
            {
                lblStatus.ForeColor = System.Drawing.Color.Salmon;
                btnOdbij.Hide();
                btnPrihvati.Hide();
                btnZavrsi.Hide();
            }
            else if (narudzba.NarudzbaStatusId == 2)
            {
                lblStatus.ForeColor = System.Drawing.Color.Orange;
                btnOdbij.Hide();
                btnPrihvati.Hide();
                btnZavrsi.Show();
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Blue;
                btnZavrsi.Visible = false;
            }

           await LoadProizvodi();
        }
  
       
        private async void frmNarudzbaDetalji_Load(object sender, EventArgs e)
        {
           await UcitajNarudzbu();
         
        }

        private async void cmbNarudzbaStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest request = new NarudzbaUpsertRequest();

            Model.Narudzbe entity = null;
            entity = await _narudzbe.Update<Model.Narudzbe>(NarudzbaID.Value, request);
        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest request = new NarudzbaUpsertRequest();
            request.NarudzbaStatusId = 4;
            Model.Narudzbe entity = null;
            entity = await _narudzbe.Update<Model.Narudzbe>(NarudzbaID.Value, request);
            var narudzba = await _narudzbe.GetById<Model.Narudzbe>(NarudzbaID);
            lblStatus.Text = "ODBIJENO";
        
            lblStatus.ForeColor = System.Drawing.Color.Red;
            btnOdbij.Hide();
            btnPrihvati.Hide();
            btnZavrsi.Hide();
        }

        private async void btnPrihvati_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest request = new NarudzbaUpsertRequest();
            request.NarudzbaStatusId = 2;
            Model.Narudzbe entity = null;
            entity = await _narudzbe.Update<Model.Narudzbe>(NarudzbaID.Value, request);
            var narudzba = await _narudzbe.GetById<Model.Narudzbe>(NarudzbaID);
            lblStatus.Text = "U pripremi";
            lblStatus.ForeColor = System.Drawing.Color.Orange;
            btnOdbij.Hide();
            btnPrihvati.Hide();
            btnZavrsi.Show();
        }

        private async void btnZavrsi_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest request = new NarudzbaUpsertRequest();
            request.NarudzbaStatusId = 3;
            Model.Narudzbe entity = null;
            entity = await _narudzbe.Update<Model.Narudzbe>(NarudzbaID.Value, request);
            var narudzba = await _narudzbe.GetById<Model.Narudzbe>(NarudzbaID);
            lblStatus.Text = "Gotovo";
            lblStatus.ForeColor = System.Drawing.Color.Salmon;
            btnOdbij.Hide();
            btnPrihvati.Hide();
            btnZavrsi.Hide();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

 
    }
}
