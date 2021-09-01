using eRestoran.Model.Requests;
using eRestoran.WinUI.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace eRestoran.WinUI.Korisnici
{
  
        public partial class frmKlijentProfil : Form
        {
            APIService _service = new APIService("Korisnici");
     
            int? ClanID = null;
    
        byte[] tempSlika = null;
        bool SlikaMijenjana = false;
        KorisniciInsertRequest request=new KorisniciInsertRequest();
        KorisniciUpdateRequest request2 = new KorisniciUpdateRequest();

        frmIndex obj = (frmIndex)Application.OpenForms["frmIndex"]; 
        public frmKlijentProfil(int? ClanId=null)
            {
                ClanID = ClanId;
                InitializeComponent();

            }
           
           
          
           
            private async void SpremiNovogClana()
            {
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Password polje i potvrda nisu isti!");
            }
            else
            {
                if (ValidateChildren())
                {

                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("Dodajte sliku", "Niste dodali sliku", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    request.Email = txtEmail.Text;
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.Telefon = txtTelefon.Text;
                    request.UlogaId = 2;
                    request.KorisnickoIme = txtUsername.Text;
                    request.Password = txtPassword.Text;
                    request.PasswordPotvrda = txtPassword2.Text;

                    Model.Korisnici entity = null;
                    entity = await _service.Insert<Model.Korisnici>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        obj.RefreshUposlenike();
                        this.Close();
                    }
                }
            }
            
            }
            private async void frmKlijentProfil_Load(object sender, EventArgs e)
            {
               

                if (ClanID != null)
                {
                    
                    var korisnik = await _service.GetById<Model.Korisnici>(ClanID);
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtEmail.Text = korisnik.Email;
                       txtUsername.Text = korisnik.KorisnickoIme;
                chb_Status.Checked = korisnik.Status;
                    txtTelefon.Text = korisnik.Telefon;

                tempSlika = korisnik.Slika;
                    byte[] slika = korisnik.Slika;
                    if (slika.Length > 0)
                        pictureBox1.Image = byteArrayToImage(slika);
                }
            }
            private Image byteArrayToImage(byte[] byteArray)
            {
                Image image;

                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    image = Image.FromStream(ms);
                }

                return image;
            }
            private async void btnUpdate_Click(object sender, EventArgs e)
            {
              
                if (ValidateChildren())
                {
                    if (ClanID != null)
                    {
                        UpdateClan();
                    }
                    else if (ClanID == null)
                    {
                        SpremiNovogClana();
                    }
                }
            }

            private async void UpdateClan()
            {

            request2.KorisnickoIme = txtUsername.Text;
            request2.Email = txtEmail.Text;
            request2.Ime = txtIme.Text;
            request2.Prezime = txtPrezime.Text;
            request2.Status = chb_Status.Checked;
            request2.Telefon = txtTelefon.Text;
            request2.Password = txtPassword.Text;
            request2.PasswordPotvrda = txtPassword2.Text;
            request2.UlogaId = 2;

            if (!SlikaMijenjana)
            {
                request2.Slika = tempSlika;
            }

                int id = ClanID ?? default(int);
                var korisnik = await _service.Update<Model.Korisnici>(id, request2);
                if (korisnik != null)
                {
                    MessageBox.Show("Uspjesno ste spremili izmjene!");
                obj.RefreshUposlenike();
                this.Close();
                }
            }


        private async Task<bool> EmailExixsts()
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest
            {
                Email = txtEmail.Text
            };
            List<Model.Korisnici> korisnik = await _service.Get<List<Model.Korisnici>>(request);
            if (ClanID == null && korisnik.Count > 0)
            {
                return true;
            }
            else if (ClanID != null && korisnik.Count > 0)
            {
                if (korisnik[0].KorisnikId != ClanID)
                {
                    return true;
                }
            }
            return false;
        }

       
        private void Clear()
            {
                ClanID = null;
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
            txtSlika.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";

            pictureBox1.Image = null;
            }

            private void frmDodajClana_FormClosed(object sender, FormClosedEventArgs e)
            {
            this.Close();
          
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
                if (tempSlika!=null)
                {
                    request2.Slika = file;
                }
                else
                {
                    request.Slika = file;

                }
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
                SlikaMijenjana = true;
            }
        }
    }
    }

