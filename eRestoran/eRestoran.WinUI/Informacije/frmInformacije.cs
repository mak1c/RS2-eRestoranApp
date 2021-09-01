using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Informacije
{
    public partial class frmInformacije : Form
    {
        private readonly APIService _apiService = new APIService("Informacije");
        byte[] tempSlika = null;
        bool SlikaMijenjana = false;
        public frmInformacije()
        {
            InitializeComponent();
            
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        InformacijeUpsertRequest request = new InformacijeUpsertRequest(); 

        private async void txtSpremi_Click(object sender, EventArgs e)
        {
           string RadnoOd = RadimoOdPicker.Value.Hour.ToString() + ":" + RadimoOdPicker.Value.Minute.ToString()+":00";
            string RadnoDo = RadimoDoPicker.Value.Hour.ToString() + ":" + RadimoDoPicker.Value.Minute.ToString() + ":00";

            request.NazivObjekta = txtNaziv.Text;
            request.BrojTelefona = txtTelefon.Text;
            request.RadimoOd = RadimoOdPicker.Value;
            request.RadimoDo = RadimoDoPicker.Value;
            request.Lokacija = txtAdresa.Text;
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("Nije spremljeno, dodajte sliku !");
            }

            if (!SlikaMijenjana)
            {
                request.Slika = tempSlika;
            }
            var Informacije = await _apiService.Update<Model.Informacije>(1, request);


            if (Informacije != null)
            {
                MessageBox.Show("Uspješno izvršeno");

            }
             Ucitaj();

    }

       
        private void btnOdaberi_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                string ext = Path.GetExtension(openFileDialog1.FileName);
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
                SlikaMijenjana = true;
            }
        }
        private async void Ucitaj()
        {

            Model.Informacije entity = await _apiService.GetById<Model.Informacije>(1);

            txtNaziv.Text = entity.NazivObjekta;
            txtAdresa.Text = entity.Lokacija;
            txtTelefon.Text = entity.BrojTelefona;
            if (entity.Slika != null)
            {
                pictureBox1.Image = ByteToImage(entity.Slika);

            }

            tempSlika = entity.Slika;
            RadimoOdPicker.Value = DateTime.Parse(entity.RadimoOd.ToShortTimeString());
            RadimoDoPicker.Value = DateTime.Parse(entity.RadimoDo.ToShortTimeString());
            SlikaMijenjana = false;



        }

        private void frmInformacije_Load(object sender, EventArgs e)
        {
          Ucitaj();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Naziv ne moze biti prazan!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, "Adresa ne moze biti prazan!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Telefon polje ne moze biti prazno!");
                e.Cancel = true;
            }
            else if(!Regex.Match(txtTelefon.Text, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtTelefon, "Dozvoljeni su samo brojevi!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }
    }
}
