
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using eRestoran.Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace eRestoran.WinUI.Obavijest
{

    public partial class frmNovaObavijest : Form
    {
        private readonly APIService _service = new APIService("obavijest");
        private int? _id = null;
        public frmNovaObavijest(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }
        ObavijestInsertRequest request = new ObavijestInsertRequest();
        frmIndex obj = (frmIndex)Application.OpenForms["frmIndex"];

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
   
            Model.Obavijest entity = null;
            if (!_id.HasValue)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    var request = new ObavijestInsertRequest
                    {
                        Naslov = txtNaslov.Text,
                        Sadrzaj = txtSadrzaj.Text,
                        DatumObjave = DateTime.Now
                    };
                    entity = await _service.Insert<Model.Obavijest>(request);
                }
            }
            else
            {
                var request = new ObavijestInsertRequest
                {
                    Naslov = txtNaslov.Text,
                    Sadrzaj = txtSadrzaj.Text,
                    DatumObjave = DateTime.Now
                };
                entity = await _service.Update<Model.Obavijest>(_id.Value, request);
            }



          

            if (entity != null)
            {
                MessageBox.Show("Uspješno izvršeno");
                obj.RefreshObavijesti();
                this.Close();
            }
            
        }

        private async void frmNovaObavijest_Load_1(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var entity = await _service.GetById<Model.Obavijest>(_id);
                txtNaslov.Text = entity.Naslov;
                txtSadrzaj.Text = entity.Sadrzaj;
             
               
            }

        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                errorProvider1.SetError(txtNaslov, "Naslov ne moze biti prazan!");
                e.Cancel = true;
            }
            if (!string.IsNullOrWhiteSpace(txtNaslov.Text) && Regex.Match(txtNaslov.Text, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                errorProvider1.SetError(txtNaslov, "Nisu dozvoljeni samo brojevi!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaslov, null);
            }
        }

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSadrzaj.Text))
            {
                errorProvider1.SetError(txtSadrzaj, "Sadržaj ne moze biti prazan!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSadrzaj, null);
            }
        }
    }
       

    }

