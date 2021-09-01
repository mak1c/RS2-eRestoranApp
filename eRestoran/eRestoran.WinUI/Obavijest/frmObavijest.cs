using eRestoran.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Obavijest
{
    public partial class frmObavijest : Form
    {
        private readonly APIService _apiService = new APIService("obavijest");
        public frmObavijest()
        {
            InitializeComponent();
        }

        private async void btn_Prikazi_Click(object sender, EventArgs e)
        {
            var search = new ObavijestSearchRequest()
            {
                Naslov = txtPretraga.Text
        };
            var result =await _apiService.Get<List<Model.Obavijest>>(search);
            dgvObavijesti.DataSource = result;
        }
    }
}
