using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq; 
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Proizvodi
{
    public partial class frmKategorije : Form
    {

        private readonly APIService _kategorije = new APIService("Kategorija");
        int? _id = null;
        byte[] tempSlika = null;
        bool SlikaMijenjana = false;
        public frmKategorije()
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



        private async Task<bool> KategorijaExits(bool New)
        {
            int? kategorijaId = null;
            if (New == false)
            {
                kategorijaId = _id;
            }
            if (!String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                KategorijaSearchRequest request = new KategorijaSearchRequest
                {
                    Naziv = txtNaziv.Text
                };
                var list = await _kategorije.Get<List<Model.Kategorija>>(request);
                if (list.Count > 0 && kategorijaId == null)
                {
                    errorProvider1.SetError(txtNaziv, "Kategorija već postoji!");
                    return true;
                }
                else if (list.Count > 0 && _id != null)
                {
                    if (list[0].KategorijaId != kategorijaId)
                    {
                        errorProvider1.SetError(txtNaziv, "Kategorija već postoji!");
                        return true;
                    }
                }
            }
            errorProvider1.SetError(txtNaziv, null);
            return false;
        }


        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorija>>(null);
            dgvKategorije.AutoGenerateColumns = false;
            dgvKategorije.DataSource = result;
        }


        KategorijaUpsertRequest request = new KategorijaUpsertRequest();





        private void bunifuButton1_Click(object sender, EventArgs e)
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
                pictureBox.Image = image;
                SlikaMijenjana = true;
            }
        }









        private async void bunifuButton2_Click(object sender, EventArgs e)
        {
            bool odradio = false;
            request.Naziv = txtNaziv.Text;
            request.Opis = txtOpis.Text;
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Dodajte sliku", "Niste dodali sliku", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.Kategorija entity = null;
           

           
            if (!_id.HasValue)
            {
                if (ValidateChildren())
                {
                    var _kategorijaPostoji = await KategorijaExits(true);
                    if (_kategorijaPostoji == false)
                    {


                        entity = await _kategorije.Insert<Model.Kategorija>(request);

                    }
                    else
                    {
                        MessageBox.Show("Postoji kategorija sa istim imenom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (_id.HasValue)
            {
                var _kategorijaPostoji = await KarticaExists();
                if (_kategorijaPostoji)
                {
                    MessageBox.Show("Postoji kategorija sa istim imenom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidateChildren(ValidationConstraints.Enabled) && _kategorijaPostoji == false)
                {

                    if (!SlikaMijenjana)
                    {
                        request.Slika = tempSlika;
                    }
                    odradio = true;
                    entity = await _kategorije.Update<Model.Kategorija>(_id.Value, request);
                }
            }
            
            if (entity != null&&odradio)
            {
                MessageBox.Show("Uspješno izvršeno");
                Clear();
                odradio = false;
                await LoadKategorije();

            }
        }

        

    

        private async Task UcitajKategorije()
        {

            var result = await _kategorije.Get<List<Model.Kategorija>>(new KategorijaSearchRequest()
            {
                
               

            });
            dgvKategorije.AutoGenerateColumns = false;
            dgvKategorije.DataSource = result;
        }
        private void Clear()
        {

            txtNaziv.Text = "";
            txtOpis.Text = "";
            txtSlika.Text = "";
            pictureBox.Image = null;
            _id = null;
            SlikaMijenjana = false;
        }
        private async void Ucitaj()
        {
            if (_id.HasValue)
            {
                var entity = await _kategorije.GetById<Model.Kategorija>(_id);

                txtNaziv.Text = entity.Naziv;
                txtOpis.Text = entity.Opis;
              
                
                pictureBox.Image = ByteToImage(entity.Slika);
                tempSlika = entity.Slika;


            }

        }
        private async void frmKategorije_Load(object sender, EventArgs e)
        {
           await LoadKategorije();
        }


        private async void dgvKategorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int _id = Int32.Parse(dgvKategorije.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                await _kategorije.Delete<Model.Kategorija>(_id);
                await LoadKategorije();
            }


            if (e.ColumnIndex == 3)
            {
                _id = Int32.Parse(dgvKategorije.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Ucitaj();

            }
 
        }



        private async Task<bool> KarticaExists()
        {
            KategorijaSearchRequest request = new KategorijaSearchRequest
            {
                Naziv = txtNaziv.Text
            };
            List<Model.Kategorija> kategorija = await _kategorije.Get<List<Model.Kategorija>>(request);
            if (_id == null && kategorija.Count > 0)
            {
                return true;
            }
            else if (_id != null && kategorija.Count > 0)
            {
                if (kategorija[0].KategorijaId != _id)
                {
                    return true;
                }
            }
            return false;
        }


        private async  void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNaziv, "Naziv ne moze biti prazan!");
                
            }
            else if (!string.IsNullOrWhiteSpace(txtNaziv.Text) && Regex.Match(txtNaziv.Text, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNaziv, "Nisu dozvoljeni samo brojevi!");

            }
 


            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtNaziv, null);
            }
        }

 
    }
}
