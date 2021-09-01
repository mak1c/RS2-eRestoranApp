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
    public partial class frmProizvodi : Form
    {
        private readonly APIService _apiServiceKategorija = new APIService("Kategorija");
        private readonly APIService _apiServiceProizvodi = new APIService("Proizvodi");
        private int? _id = null;
        private bool SlikaMijenjana = false;
        byte[] TempSlika = null;
        public frmProizvodi()
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
        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {

                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();

                int width = 480;
                var height = UInt16.MaxValue - 36; //succeeds at 65499, 65500
                try
                {
                    while (true)
                    {
                        var image = new Bitmap(width, height);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            //error will throw from here
                            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        height += 1;
                    }
                }
                catch (Exception ex)
                {
                    //explodes at 65501 with "A generic error occurred in GDI+."
                }
            }
        }
        private async Task LoadKategorijeProizvoda()
        {
            var result = await _apiServiceKategorija.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija());
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.ValueMember = "KategorijaId";
            cmbKategorije.DataSource = result;
 
        }
        private async Task LoadKategorijeProizvoda2()
        {
            var result = await _apiServiceKategorija.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija());

            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "KategorijaId";
            comboBox2.DataSource = result;
        }
        private async void frmProizvodi_Load(object sender, EventArgs e)
        {

            await LoadKategorijeProizvoda();
            await LoadKategorijeProizvoda2();
            await UcitajProizvode();
        }



        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboBox2.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await UcitajProizvode(id);
            }
        }
        private async Task UcitajProizvode(int? kategorijaId = 0)
        {
            ProizvodiSearchRequest req = new ProizvodiSearchRequest();

            if (!String.IsNullOrWhiteSpace(txtPretragaNaziv.Text))
            {
                req.Naziv = txtPretragaNaziv.Text;
            }
            if (kategorijaId != 0)
            {
                req.KategorijaId = kategorijaId;
                var result = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(req);
                dgvProizvodi.AutoGenerateColumns = false;
                dgvProizvodi.DataSource = result;
            }
           else
            {
                var result = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(null);
                dgvProizvodi.AutoGenerateColumns = false;
                dgvProizvodi.DataSource = result;
            }
          
        }
        ProizvodiUpsertRequest request = new ProizvodiUpsertRequest();

        private async void Spremi_Click(object sender, EventArgs e)
        {


            var idObj = cmbKategorije.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int kategId))
            {
                request.KategorijaId = kategId;
            }



            
            
            Model.Proizvodi entity = null;


            if (!_id.HasValue)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    var _ItemPostoji = await ItemExits(true);
                    if (_ItemPostoji == false)
                    {
                        if (pictureBox1.Image == null)
                        {
                            MessageBox.Show("Dodajte sliku","Niste dodali sliku", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        request.Naziv = txtNaziv.Text;
                        request.Cijena = Convert.ToDecimal(txtCijena.Text);
                        request.Opis = txtOpis.Text;
                        request.VrijemePripremanja = Int32.Parse(txtVrijemePripreme.Text);
                        entity = await _apiServiceProizvodi.Insert<Model.Proizvodi>(request);
                    }
                    else
                    {
                        MessageBox.Show("Postoji proizvod sa istim imenom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (_id.HasValue)
            {
                var _ItemPostoji = await ItemExits(false);
                if (_ItemPostoji)
                {
                    MessageBox.Show("Postoji proizvod sa istim imenom!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidateChildren(ValidationConstraints.Enabled) && _ItemPostoji == false)
                {

                    request.Naziv = txtNaziv.Text;
                    request.Cijena = Convert.ToDecimal(txtCijena.Text);
                    request.Opis = txtOpis.Text;
                    request.VrijemePripremanja = Int32.Parse(txtVrijemePripreme.Text);
                    if (!SlikaMijenjana)
                    {
                        request.Slika = TempSlika;
                    }
                    entity = await _apiServiceProizvodi.Update<Model.Proizvodi>(_id.Value, request);
                }
            }
            
              
            

            if (entity != null)
            {
                MessageBox.Show("Uspješno izvršeno");
                Clear();
                
                await UcitajProizvode();
                
            }


        }

        private async void ProizvodiPretraga(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            int? _kategId=null;
            var idObj = comboBox2.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int kategId))
            {
                _kategId = kategId;
            }
            if (e.KeyChar == (char)Keys.Return)

            {
                var search = new ProizvodiSearchRequest()
                {
                    KategorijaId =_kategId
                };
                var result = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(search);
                dgvProizvodi.AutoGenerateColumns = false;
                dgvProizvodi.DataSource = result;


            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                string ext = Path.GetExtension(openFileDialog1.FileName);

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
                SlikaMijenjana = true;
            }
        }

        private void Clear()
        {

            txtNaziv.Text = "";
            txtCijena.Text = "";
            txtOpis.Text = "";
            txtVrijemePripreme.Text = "";
            cmbKategorije.Text = "";
            pictureBox1.Image = null;
            _id = null;
            SlikaMijenjana = false;
        }

        private async void Ucitaj()
        {
            if (_id.HasValue)
            {
                var entity = await _apiServiceProizvodi.GetById<Model.Proizvodi>(_id);

                txtNaziv.Text = entity.Naziv;
                txtCijena.Text = entity.Cijena.ToString();
                txtOpis.Text = entity.Opis; ;
                txtVrijemePripreme.Text = entity.VrijemePripremanja.ToString();
                cmbKategorije.SelectedValue = entity.KategorijaId;
                pictureBox1.Image = ByteToImage(entity.Slika);
                TempSlika = entity.Slika;
               

            }
            ValidateChildren();

        }


        private async void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int _id = Int32.Parse(dgvProizvodi.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                await _apiServiceProizvodi.Delete<Model.Obavijest>(_id);
                await UcitajProizvode();
            }


            if (e.ColumnIndex == 4)
            {
                _id = Int32.Parse(dgvProizvodi.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Ucitaj();

            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmKategorije frm = new frmKategorije();
            frm.Show();
        }

        private async Task<bool> ItemExits(bool New)
        {
            int? itemId = null;
            if (New == false)
            {
                itemId = _id;
            }
            if (!String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                ProizvodiSearchRequest request = new ProizvodiSearchRequest
                {
                    Naziv = txtNaziv.Text
                };
                var list = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(request);
                if (list.Count > 0 && itemId == null)
                {
                    errorProvider1.SetError(txtNaziv, "Proizvod već postoji!");
                    return true;
                }
                else if (list.Count > 0 && _id != null)
                {
                    if (list[0].ProizvodId != itemId)
                    {
                        errorProvider1.SetError(txtNaziv, "Proizvod već postoji!");
                        return true;
                    }
                }
            }
            errorProvider1.SetError(txtNaziv, null);
            return false;
        }
        private async Task<bool> KarticaExists()
        {
            ProizvodiSearchRequest request = new ProizvodiSearchRequest
            {
                Naziv = txtNaziv.Text
            };
            List<Model.Proizvodi> proizvodi = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(request);
            if (_id == null && proizvodi.Count > 0)
            {
                return true;
            }
            else if (_id != null && proizvodi.Count > 0)
            {
                if (proizvodi[0].KategorijaId != _id)
                {
                    return true;
                }
            }
            return false;
        }

        private async void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            //var postoji =await KarticaExists();
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Naziv ne moze biti prazan!");
                //e.Cancel = true;
            }
            else if (!string.IsNullOrWhiteSpace(txtNaziv.Text) && Regex.Match(txtNaziv.Text, @"^[0-9]+$", RegexOptions.IgnoreCase).Success)
            {
                //e.Cancel = true;
               
                errorProvider1.SetError(txtNaziv, "Nisu dozvoljeni samo brojevi!");

            }
            //else if (!String.IsNullOrWhiteSpace(txtNaziv.Text) && postoji && _id==null)
            //{
            //    errorProvider1.SetError(txtNaziv, "Proizvod sa istim imenom postoji!");
            //    //e.Cancel = true;
            //}
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtVrijemePripreme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtVrijemePripreme.Text))
            {
                errorProvider1.SetError(txtVrijemePripreme, "Vrijeme trajanja ne moze biti prazno!");
                //e.Cancel = true;
            }
           else if (!IsDecimalFormat(txtVrijemePripreme.Text))
            {
                errorProvider1.SetError(txtVrijemePripreme, "Mora biti broj!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtVrijemePripreme, null);
            }
        }

      

        bool IsDecimalFormat(string input)
        {
            Decimal dummy;
            return Decimal.TryParse(input, out dummy);
        }

      

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, "Cijena ne moze biti prazana!");
                //e.Cancel = true;
            }
            else if (!IsDecimalFormat(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, "Mora biti broj!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, "Opis ne moze biti prazan!");
                //e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtOpis, null);
            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var idObj = comboBox2.SelectedValue;
            var kategId = 0;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                if (id>=1)
                {
                    kategId = id;
                }
              
            }
            ProizvodiSearchRequest req = new ProizvodiSearchRequest();
            req.Naziv = txtPretragaNaziv.Text;
         
            if (kategId>=1)
            {
                req.KategorijaId = kategId;
            }
            var result = await _apiServiceProizvodi.Get<List<Model.Proizvodi>>(req);
            dgvProizvodi.AutoGenerateColumns = false;
            dgvProizvodi.DataSource = result;

        
       

        }

        private void cmbKategorije_Validating(object sender, CancelEventArgs e)
        {
            var idObj = cmbKategorije.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                if (id==0)
                {
                    errorProvider1.SetError(cmbKategorije, "Odaberi Kategoriju!");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(cmbKategorije, null);
                }

            }
            else
            {
                errorProvider1.SetError(cmbKategorije, null);
            }
        }
    }
}