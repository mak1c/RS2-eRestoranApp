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
  
        public partial class frmKorisnikProfil : Form
        {
            APIService _service = new APIService("Korisnici");
     
            int? ClanID = null;
    
        byte[] tempSlika = null;
        string stariBroj = null;
        bool SlikaMijenjana = false;
        KorisniciInsertRequest request=new KorisniciInsertRequest();
        KorisniciUpdateRequest request2 = new KorisniciUpdateRequest();

        frmIndex obj = (frmIndex)Application.OpenForms["frmIndex"];
        public frmKorisnikProfil(int? ClanId=null)
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
                    if (pictureBox1.Image==null)
                    {
                        MessageBox.Show("Dodajte sliku", "Niste dodali sliku", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    request.Status = chb_Status.Checked;
                    request.Email = txtEmail.Text;
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.Telefon = txtTelefon.Text;
                    request.UlogaId = 2;
                    request.KorisnickoIme = txtUsername.Text;
                    request.Password = txtPassword.Text;
                    request.PasswordPotvrda = txtPassword2.Text;

                 
                     var entity = await _service.Insert<Model.Korisnici>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        obj.RefreshUposlenike();
                        this.Close();
                    }
                }
            }
            
            }
            private async void frmKorisnikProfil_Load(object sender, EventArgs e)
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
                stariBroj = korisnik.Telefon;

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

            var _emailExists = await EmailExixsts();
            var _karticaExists = await KarticaExists();
            var _telefonExsts = await TelefonExixsts();

            if (ValidateChildren(ValidationConstraints.Enabled) && _emailExists == false&& _karticaExists == false && _telefonExsts == false)
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
                Email = txtEmail.Text,
                StatusPretraga=false
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

        private async Task<bool> UserNameExixsts()
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest
            {
                KorisnickoIme = txtUsername.Text,
                StatusPretraga=false
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
        private async Task<bool> TelefonExixsts()
        {
            if (txtTelefon.Text==stariBroj)
            {
                return false;
            }
            KorisniciSearchRequest request = new KorisniciSearchRequest
            {
                BrojTelefona = txtTelefon.Text,
                StatusPretraga = false
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








        private async Task<bool> KarticaExists()
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest
            {
                KorisnickoIme = txtUsername.Text,
                StatusPretraga = false
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

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Resources.Validation_Required);
                //e.Cancel = true;
            }
            else if (!Regex.Match(txtIme.Text, @"^[a-zA-ZČčĆćŽžĐđŠš ]+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtIme, "Dozvoljena su samo slova!");
                //e.Cancel = true;
            }
            else if (txtIme.Text.Length > 50)
            {
                errorProvider1.SetError(txtIme, "Maksimalna dozvoljena duzina je 50 karaktera!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Resources.Validation_Required);
                //e.Cancel = true;
            }
            else if (!Regex.Match(txtPrezime.Text, @"^[a-zA-ZČčĆćŽžĐđŠš ]+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtPrezime, "Dozvoljena su samo slova!");
                //e.Cancel = true;
            }
            else if (txtPrezime.Text.Length > 50)
            {
                errorProvider1.SetError(txtPrezime, "Maksimalna dozvoljena duzina je 50 karaktera!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private async void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text.ToString()))
            {
                errorProvider1.SetError(txtEmail, "Email polje je obavezno!");
                //e.Cancel = true;
            }
            else if (!Regex.Match(txtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtEmail, "Neispravan format Email-a!");
                //e.Cancel = true;
            }
            else if (txtEmail.Text != null)
            {
                var _emailExists = await EmailExixsts();
                if (_emailExists)
                {
                    errorProvider1.SetError(txtEmail, "Email postoji!");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtEmail, null);
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && !Regex.Match(txtTelefon.Text, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtTelefon, "Dozvoljeni su samo brojevi!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private async void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (  !Regex.Match(txtUsername.Text, @"^\w+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtUsername, "Nije dobar unos");
                //e.Cancel = true;
            }
            else
            {
                var _karticaExists = await KarticaExists();
                if (_karticaExists)
                {
                    errorProvider1.SetError(txtUsername, "Username vec postoji!");
                    e.Cancel = true;
                    return;
                }
        
                    errorProvider1.SetError(txtUsername, null);

                
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (stariBroj!=null && txtPassword.Text=="")
            {
                
               
            }
            else if (stariBroj == null && txtPassword.Text == "")
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Morate korisniku definisati lozinku");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
    }

