using eRestoran.Model.Requests;
using eRestoran.WinUI.Korisnici;
using eRestoran.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Core;

namespace eRestoran.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        
        int? rolaa = null;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
   

            try
            {
                    APIService.Username = txtUsername.Text;
                    APIService.Password = txtPassword.Text;
                    KorisniciSearchRequest request = new KorisniciSearchRequest { KorisnickoIme = txtUsername.Text };
                    List<Model.Korisnici> korisnici = await _service.Get<List<Model.Korisnici>>(request);
                    APIService.UserId = korisnici.Where(x => x.KorisnickoIme == APIService.Username).Select(x => x.KorisnikId).SingleOrDefault();
                    APIService.Rola = korisnici.Where(x => x.KorisnickoIme == APIService.Username).Select(x => x.UlogaId).SingleOrDefault();

                    //await _service.Get<dynamic>(null);

                    if (APIService.Rola == 1 || APIService.Rola == 2)
                    {
                        await _service.Get<dynamic>(null);

                        frmIndex frm = new frmIndex();
                        frm.Show();
                        this.Hide();
                        return;
                    }
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                //txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Unesite username!");
                e.Cancel = false;

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
               
                errorProvider1.SetError(txtPassword, "Morate unijeti password!");
                e.Cancel = true;
            }
            else
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
}
