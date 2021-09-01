using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
    public partial class frmLogin2 : Form
    {


        public frmLogin2()
        {
            InitializeComponent();
        }

        APIService _service = new APIService("Korisnici");

        int? rolaa = null;

       

       

       
        private async void btnPrijava_Click(object sender, EventArgs e)
        {


            try
            {
                bunifuLabel1.Text = "Učitava se...";
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
                else
                {
                    MessageBox.Show("Nemaš ovlasti!", "Zabranjen pristup!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuLabel1.Text = "";
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
      
                if (MessageBox.Show("Želiš zatvoriti program?", "Potvrdi izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                Application.Exit();
            }
        }
        bool moving;
        Point offset;
        Point original;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panel1.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }
        void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }
        void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            panel1.Capture = false;
        }
    }

    //public Image SetImageOpacity(Image image, float opacity)
    //{
    //    Bitmap bmp = new Bitmap(image.Width, image.Height);
    //    using (Graphics g = Graphics.FromImage(bmp))
    //    {
    //        ColorMatrix matrix = new ColorMatrix();
    //        matrix.Matrix33 = opacity;
    //        ImageAttributes attributes = new ImageAttributes();
    //        attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
    //                                          ColorAdjustType.Bitmap);
    //        g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
    //                           0, 0, image.Width, image.Height,
    //                           GraphicsUnit.Pixel, attributes);
    //    }
    //    return bmp;
    //}
}

