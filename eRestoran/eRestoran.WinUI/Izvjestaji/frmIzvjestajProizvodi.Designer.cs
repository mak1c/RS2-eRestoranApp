namespace eRestoran.WinUI.Izvjestaji
{
    partial class frmIzvjestajKategorijeProizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvjestajKategorijeProizvodi));
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dgvMjesecIzvjestaj = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MjesecBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjesecNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaZarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblnajveci = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblnajvise = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesecIzvjestaj)).BeginInit();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.panel1);
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(784, 598);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuGroupBox3);
            this.panel1.Controls.Add(this.bunifuGroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 576);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox3.BorderRadius = 1;
            this.bunifuGroupBox3.BorderThickness = 1;
            this.bunifuGroupBox3.Controls.Add(this.dgvMjesecIzvjestaj);
            this.bunifuGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(0, 47);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(778, 529);
            this.bunifuGroupBox3.TabIndex = 1;
            this.bunifuGroupBox3.TabStop = false;
            // 
            // dgvMjesecIzvjestaj
            // 
            this.dgvMjesecIzvjestaj.AllowCustomTheming = false;
            this.dgvMjesecIzvjestaj.AllowUserToAddRows = false;
            this.dgvMjesecIzvjestaj.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMjesecIzvjestaj.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMjesecIzvjestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMjesecIzvjestaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMjesecIzvjestaj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMjesecIzvjestaj.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMjesecIzvjestaj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMjesecIzvjestaj.ColumnHeadersHeight = 28;
            this.dgvMjesecIzvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MjesecBroj,
            this.MjesecNaziv,
            this.BrojNarudzbi,
            this.UkupnaZarada});
            this.dgvMjesecIzvjestaj.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMjesecIzvjestaj.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMjesecIzvjestaj.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMjesecIzvjestaj.CurrentTheme.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMjesecIzvjestaj.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMjesecIzvjestaj.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvMjesecIzvjestaj.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMjesecIzvjestaj.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMjesecIzvjestaj.CurrentTheme.Name = null;
            this.dgvMjesecIzvjestaj.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMjesecIzvjestaj.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMjesecIzvjestaj.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            this.dgvMjesecIzvjestaj.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMjesecIzvjestaj.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMjesecIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMjesecIzvjestaj.EnableHeadersVisualStyles = false;
            this.dgvMjesecIzvjestaj.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.dgvMjesecIzvjestaj.HeaderBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvMjesecIzvjestaj.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMjesecIzvjestaj.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMjesecIzvjestaj.Location = new System.Drawing.Point(3, 19);
            this.dgvMjesecIzvjestaj.Name = "dgvMjesecIzvjestaj";
            this.dgvMjesecIzvjestaj.ReadOnly = true;
            this.dgvMjesecIzvjestaj.RowHeadersVisible = false;
            this.dgvMjesecIzvjestaj.RowTemplate.Height = 40;
            this.dgvMjesecIzvjestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjesecIzvjestaj.Size = new System.Drawing.Size(772, 507);
            this.dgvMjesecIzvjestaj.TabIndex = 0;
            this.dgvMjesecIzvjestaj.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.MediumSeaGreen;
            // 
            // MjesecBroj
            // 
            this.MjesecBroj.DataPropertyName = "MjesecBroj";
            this.MjesecBroj.HeaderText = "#";
            this.MjesecBroj.Name = "MjesecBroj";
            this.MjesecBroj.ReadOnly = true;
            // 
            // MjesecNaziv
            // 
            this.MjesecNaziv.DataPropertyName = "MjesecNaziv";
            this.MjesecNaziv.HeaderText = "MjesecNaziv";
            this.MjesecNaziv.Name = "MjesecNaziv";
            this.MjesecNaziv.ReadOnly = true;
            // 
            // BrojNarudzbi
            // 
            this.BrojNarudzbi.DataPropertyName = "MjesecBrojProdatih";
            this.BrojNarudzbi.HeaderText = "BrojNarudzbi";
            this.BrojNarudzbi.Name = "BrojNarudzbi";
            this.BrojNarudzbi.ReadOnly = true;
            // 
            // UkupnaZarada
            // 
            this.UkupnaZarada.DataPropertyName = "MjesecUkupno";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "0.00 KM";
            dataGridViewCellStyle3.NullValue = null;
            this.UkupnaZarada.DefaultCellStyle = dataGridViewCellStyle3;
            this.UkupnaZarada.HeaderText = "UkupnaZarada";
            this.UkupnaZarada.Name = "UkupnaZarada";
            this.UkupnaZarada.ReadOnly = true;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.lblnajveci);
            this.bunifuGroupBox2.Controls.Add(this.lblnajvise);
            this.bunifuGroupBox2.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox2.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(778, 47);
            this.bunifuGroupBox2.TabIndex = 0;
            this.bunifuGroupBox2.TabStop = false;
            // 
            // lblnajveci
            // 
            this.lblnajveci.AllowParentOverrides = false;
            this.lblnajveci.AutoEllipsis = false;
            this.lblnajveci.CursorType = null;
            this.lblnajveci.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblnajveci.Location = new System.Drawing.Point(241, 23);
            this.lblnajveci.Name = "lblnajveci";
            this.lblnajveci.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnajveci.Size = new System.Drawing.Size(0, 0);
            this.lblnajveci.TabIndex = 3;
            this.lblnajveci.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblnajveci.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblnajvise
            // 
            this.lblnajvise.AllowParentOverrides = false;
            this.lblnajvise.AutoEllipsis = false;
            this.lblnajvise.CursorType = null;
            this.lblnajvise.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblnajvise.Location = new System.Drawing.Point(241, -7);
            this.lblnajvise.Name = "lblnajvise";
            this.lblnajvise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnajvise.Size = new System.Drawing.Size(0, 0);
            this.lblnajvise.TabIndex = 2;
            this.lblnajvise.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblnajvise.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(64, 22);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(171, 30);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "NAJVEĆI PROFIT:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(29, -7);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(206, 30);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "NAJVIŠE NARUDŽBI:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmIzvjestajKategorijeProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 598);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "frmIzvjestajKategorijeProizvodi";
            this.Text = "frmIzvjestajKategorijeProizvodi";
            this.Load += new System.EventHandler(this.frmIzvjestajKategorijeProizvodi_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesecIzvjestaj)).EndInit();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMjesecIzvjestaj;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblnajveci;
        private Bunifu.UI.WinForms.BunifuLabel lblnajvise;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjesecBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjesecNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaZarada;
    }
}