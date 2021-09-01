using eRestoran.Model.Requests;
using eRestoran.WinUI.Informacije;
using eRestoran.WinUI.Izvjestaji;
using eRestoran.WinUI.Korisnici;
using eRestoran.WinUI.Narudzbe;
using eRestoran.WinUI.Obavijest;
using eRestoran.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
  
    public partial class frmIndex : Form
    {
        private readonly APIService _apiService = new APIService("obavijest");
        private readonly APIService _apiServiceUposlenici = new APIService("Korisnici");
        private readonly APIService _apiServiceKategorija = new APIService("Kategorija");
        public frmIndex()
        {
            InitializeComponent();
            

        }
        public class Status
        {
            public int Broj { get; set; }
            public string StatusNaziv { get; set; }
        }
        private void btnMenuSide_Click(object sender, EventArgs e)
        {
     
            if (((Control)sender).Text == "Uposlenici")
            {
                if (APIService.Rola!=1)
                {
                    MessageBox.Show("Pristup uposlenicima ima samo administrator!", "Niste ovlašteni!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               

                LoadUposlenike();
                
            }
            pages.SetPage(((Control)sender).Text);
            if (((Control)sender).Text == "Obavijesti")
            {
                LoadObavijesti();
                //DataGridViewButtonColumn c = (DataGridViewButtonColumn)dgvObavijesti.Columns["Obriši"];
                //c.FlatStyle = FlatStyle.Popup;
                ////c.DefaultCellStyle.ForeColor = Color.Navy;
                //c.DefaultCellStyle.BackColor = Color.MediumVioletRed;
            }
        }
        private void Refresh(string Tab)
        {
            pages.SetPage(Tab);

        }
     
        private async void LoadObavijesti()
        {
            var search = new ObavijestSearchRequest()
            {
                Naslov = txtPretragaObavijesti.Text
            };
            var result = await _apiService.Get<List<Model.Obavijest>>(search);
            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = result;
           
        }
        private async void LoadUposlenike()
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtUposlenikIme.Text,
                Prezime = txtUposlenikPrezime.Text,
                UlogaId=2,
                StatusPretraga=false
            };
            var result = await _apiServiceUposlenici.Get<List<Model.Korisnici>>(search);
            dgv_Uposlenici.AutoGenerateColumns = false;
            dgv_Uposlenici.DataSource = result;



            List<Status> rezult = new List<Status>();
            rezult.Insert(0, new Status());
            rezult.Insert(1, new Status() { Broj = 1, StatusNaziv = "Aktivan" });
            rezult.Insert(2, new Status() { Broj = 2, StatusNaziv = "Neaktivan" });
            cmbStatusUposlenika.DisplayMember = "StatusNaziv";
            cmbStatusUposlenika.ValueMember = "Broj";
            cmbStatusUposlenika.DataSource = rezult;

        }
        private async void LoadUposlenike2(int id=-1)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtUposlenikIme.Text,
                Prezime = txtUposlenikPrezime.Text,
                UlogaId = 2,
                
            };
            if (cmbStatusUposlenika.SelectedIndex!=0 &&id!=-1)
            {
                if (id==1)
                {
                    search.Status = true;
                }
                else
                {
                    search.Status = false;
                }
                search.StatusPretraga = true;
            }
            else
            {
                search.StatusPretraga = false;
            }
            var result = await _apiServiceUposlenici.Get<List<Model.Korisnici>>(search);
            dgv_Uposlenici.AutoGenerateColumns = false;
            dgv_Uposlenici.DataSource = result;





        }
        private async void dgv_Uposlenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                int _id = Int32.Parse(dgv_Uposlenici.Rows[e.RowIndex].Cells["KorisnikId"].Value.ToString());
                frmKorisnikProfil frm = new frmKorisnikProfil(_id);
                frm.Show();
            }


   

        }
        public  void RefreshObavijesti()
        {
            LoadObavijesti();
        }
        public void RefreshUposlenike()
        {
            LoadUposlenike();
        }
        private  void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            frmNovaObavijest frm = new frmNovaObavijest();
            frm.Show();
        }
        private async void btnRefreshObavijesti_Click(object sender, EventArgs e)
        {
            var search = new ObavijestSearchRequest()
            {
                Naslov = txtPretragaObavijesti.Text
            };
            var result = await _apiService.Get<List<Model.Obavijest>>(search);
            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = result;
        }
 
        private async void dgvObavijesti_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int _id = Int32.Parse(dgvObavijesti.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                frmNovaObavijest frm = new frmNovaObavijest(_id);

                frm.Show();
            }
            if (e.ColumnIndex == 5)
            {
                int _id = Int32.Parse(dgvObavijesti.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                await _apiService.Delete<Model.Obavijest>(_id);
                MessageBox.Show("Uspješno izvršeno!!", "Obrisano!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadObavijesti();
            }
        }
        private async void ObavijestiPretraga(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                var search = new ObavijestSearchRequest()
                {
                    Naslov = txtPretragaObavijesti.Text
                };
                var result = await _apiService.Get<List<Model.Obavijest>>(search);
                dgvObavijesti.DataSource = result;
            }
        }

        private void btnUposlenicii_Click(object sender, EventArgs e)
        {
            pages.SetPage("Uposlenici");
        }

        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtUposlenikIme.Text,
                Prezime = txtUposlenikPrezime.Text,
                UlogaId=2
            };
            var result = await _apiServiceUposlenici.Get<List<Model.Korisnici>>(search);
            dgv_Uposlenici.AutoGenerateColumns = false;
            dgv_Uposlenici.DataSource = result;
        }

        private void btnUposlenikDodaj_Click(object sender, EventArgs e)
        {
            frmKorisnikProfil frm = new frmKorisnikProfil();
            frm.Show();
        }



        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            frmNovaObavijest frm = new frmNovaObavijest();
            pages.Hide();
            frm.TopLevel = false;
            SubPanel.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);

            frmProizvodi frm = new frmProizvodi();
            frm.TopLevel = false;
            tabPage3.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnMenuSide_Click_1(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);

            frmNarudzbe frm = new frmNarudzbe();
            frm.TopLevel = false;
            tabPage1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmInformacije frm = new frmInformacije();
            pages.SetPage(((Control)sender).Text);

            
            frm.TopLevel = false;
            tabPage5.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            frmKlijenti frm = new frmKlijenti();
            pages.SetPage(((Control)sender).Text);


            frm.TopLevel = false;
            tabPage10.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj();
            //frm.Show();
            pages.SetPage(((Control)sender).Text);


            frm.TopLevel = false;
            tabPage6.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            pages.SetPage("Narudžbe");
            frmNarudzbe frm = new frmNarudzbe();
            frm.TopLevel = false;
            tabPage1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbStatusUposlenika.SelectedIndex;
            if (int.TryParse(idObj.ToString(),out int id))
            {
                LoadUposlenike2(id);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoadUposlenike();
        }

        private async void btnObavijestiPretraga_Click(object sender, EventArgs e)
        {
            var search = new ObavijestSearchRequest()
            {
                Naslov = txtPretragaObavijesti.Text
            };
            var result = await _apiService.Get<List<Model.Obavijest>>(search);
            dgvObavijesti.DataSource = result;
        }
    }
}
    

