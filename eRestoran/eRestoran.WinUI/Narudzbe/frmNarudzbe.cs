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
    public partial class frmNarudzbe : Form
    {
        private readonly APIService _narudzbe = new APIService("Narudzbe");
        private readonly APIService _narudzbeS = new APIService("NarudzbaStatus");
        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private async Task LoadNarudzbeStatus()
        {
            var result = await _narudzbeS.Get<List<Model.NarudzbaStatus>>(null);
            cmbStatusNarudzbe.DisplayMember = "Status";
            cmbStatusNarudzbe.ValueMember = "NarudzbaStatusId";
            cmbStatusNarudzbe.DataSource = result;
        }

        private async Task LoadNarudzbe()
        {
            NarudzbeSearchRequest req = new NarudzbeSearchRequest();
            req.DatumPretraga = false;

            var result = await _narudzbe.Get<List<Model.Narudzbe>>(null);
            dgvNarudzbe.AutoGenerateColumns = false;
            dgvNarudzbe.DataSource = result;
        }
        private async void frmNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadNarudzbe();
            await LoadNarudzbeStatus();
        }
        private async void cmbStatusNarudzbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbStatusNarudzbe.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await UcitajNarudzbe(id);
            }
        }
 
        private async Task UcitajNarudzbe(int narudzbaid=0)
        {
           
            var result = await _narudzbe.Get<List<Model.Narudzbe>>(new NarudzbeSearchRequest()
            {
               
            NarudzbaStatusId = narudzbaid
            

            });
            dgvNarudzbe.AutoGenerateColumns = false;
            dgvNarudzbe.DataSource = result;
        }
        private  void dgvNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int _id = Int32.Parse(dgvNarudzbe.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                frmNarudzbaDetalji frm = new frmNarudzbaDetalji(_id);
                frm.Show();
        
            }

        
        }

        private async void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            await LoadNarudzbe();
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            NarudzbeSearchRequest request = new NarudzbeSearchRequest();
            var idObj = cmbStatusNarudzbe.SelectedValue;
           
            if (int.TryParse(idObj.ToString(), out int id))
            {
                request.NarudzbaStatusId = id;
            }
         
            request.DatumPretraga = bunifuCheckBox1.Checked;
            request.DatumNarudzbe = dateNarudzbe.Value.Date;
            var result = await _narudzbe.Get<List<Model.Narudzbe>>(request);

            dgvNarudzbe.AutoGenerateColumns = false;
            dgvNarudzbe.DataSource = result;

        }

     

    }
}
