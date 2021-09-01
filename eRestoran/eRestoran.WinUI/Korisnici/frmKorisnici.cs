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
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("obavijest");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private  void btn_Prikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
        };
            //var result =await _apiService.Get<List<Model.Korisnik>>(search);
            dgvObavijesti.DataSource = null;
        }
    }
}
