namespace eRestoran.WinUI.Narudzbe
{
    partial class frmNarudzbaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzbaDetalji));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtPaymentId = new System.Windows.Forms.Label();
            this.lblBAM = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUkupno = new Bunifu.UI.WinForms.BunifuLabel();
            this.grpProizvodi = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dgvNarudzbaProizvodiV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoPoProizvodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZavrsi = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPrihvati = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnOdbij = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblBrojTelefona = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblVrijeme = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAdresa = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblIme = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPlacenoo = new System.Windows.Forms.Label();
            this.bunifuGroupBox1.SuspendLayout();
            this.grpProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaProizvodiV)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txtPlacenoo);
            this.bunifuGroupBox1.Controls.Add(this.txtPaymentId);
            this.bunifuGroupBox1.Controls.Add(this.lblBAM);
            this.bunifuGroupBox1.Controls.Add(this.lblUkupno);
            this.bunifuGroupBox1.Controls.Add(this.grpProizvodi);
            this.bunifuGroupBox1.Controls.Add(this.btnZavrsi);
            this.bunifuGroupBox1.Controls.Add(this.btnPrihvati);
            this.bunifuGroupBox1.Controls.Add(this.btnOdbij);
            this.bunifuGroupBox1.Controls.Add(this.lblStatus);
            this.bunifuGroupBox1.Controls.Add(this.lblBrojTelefona);
            this.bunifuGroupBox1.Controls.Add(this.lblVrijeme);
            this.bunifuGroupBox1.Controls.Add(this.lblAdresa);
            this.bunifuGroupBox1.Controls.Add(this.lblIme);
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(789, 562);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.AutoSize = true;
            this.txtPaymentId.Location = new System.Drawing.Point(576, 123);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(67, 15);
            this.txtPaymentId.TabIndex = 11;
            this.txtPaymentId.Text = "PaymentId:";
            // 
            // lblBAM
            // 
            this.lblBAM.AllowParentOverrides = false;
            this.lblBAM.AutoEllipsis = false;
            this.lblBAM.CursorType = null;
            this.lblBAM.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBAM.Location = new System.Drawing.Point(409, 103);
            this.lblBAM.Name = "lblBAM";
            this.lblBAM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBAM.Size = new System.Drawing.Size(54, 32);
            this.lblBAM.TabIndex = 10;
            this.lblBAM.Text = "BAM";
            this.lblBAM.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBAM.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AllowParentOverrides = false;
            this.lblUkupno.AutoEllipsis = false;
            this.lblUkupno.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUkupno.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUkupno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUkupno.Location = new System.Drawing.Point(351, 103);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUkupno.Size = new System.Drawing.Size(83, 32);
            this.lblUkupno.TabIndex = 9;
            this.lblUkupno.Text = "CIJENA";
            this.lblUkupno.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUkupno.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // grpProizvodi
            // 
            this.grpProizvodi.BorderColor = System.Drawing.Color.LightGray;
            this.grpProizvodi.BorderRadius = 1;
            this.grpProizvodi.BorderThickness = 1;
            this.grpProizvodi.Controls.Add(this.dgvNarudzbaProizvodiV);
            this.grpProizvodi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpProizvodi.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.grpProizvodi.LabelIndent = 10;
            this.grpProizvodi.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.grpProizvodi.Location = new System.Drawing.Point(6, 141);
            this.grpProizvodi.Name = "grpProizvodi";
            this.grpProizvodi.Size = new System.Drawing.Size(771, 409);
            this.grpProizvodi.TabIndex = 8;
            this.grpProizvodi.TabStop = false;
            this.grpProizvodi.Text = "Proizvodi";
            // 
            // dgvNarudzbaProizvodiV
            // 
            this.dgvNarudzbaProizvodiV.AllowCustomTheming = false;
            this.dgvNarudzbaProizvodiV.AllowUserToAddRows = false;
            this.dgvNarudzbaProizvodiV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbaProizvodiV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbaProizvodiV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbaProizvodiV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNarudzbaProizvodiV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNarudzbaProizvodiV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbaProizvodiV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNarudzbaProizvodiV.ColumnHeadersHeight = 40;
            this.dgvNarudzbaProizvodiV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proizvod,
            this.Količina,
            this.Cijena,
            this.UkupnoPoProizvodu});
            this.dgvNarudzbaProizvodiV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNarudzbaProizvodiV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbaProizvodiV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbaProizvodiV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNarudzbaProizvodiV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbaProizvodiV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNarudzbaProizvodiV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNarudzbaProizvodiV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNarudzbaProizvodiV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbaProizvodiV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNarudzbaProizvodiV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNarudzbaProizvodiV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNarudzbaProizvodiV.CurrentTheme.Name = null;
            this.dgvNarudzbaProizvodiV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNarudzbaProizvodiV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbaProizvodiV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbaProizvodiV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNarudzbaProizvodiV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbaProizvodiV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNarudzbaProizvodiV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbaProizvodiV.EnableHeadersVisualStyles = false;
            this.dgvNarudzbaProizvodiV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNarudzbaProizvodiV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNarudzbaProizvodiV.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNarudzbaProizvodiV.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNarudzbaProizvodiV.Location = new System.Drawing.Point(3, 19);
            this.dgvNarudzbaProizvodiV.Name = "dgvNarudzbaProizvodiV";
            this.dgvNarudzbaProizvodiV.ReadOnly = true;
            this.dgvNarudzbaProizvodiV.RowHeadersVisible = false;
            this.dgvNarudzbaProizvodiV.RowTemplate.Height = 40;
            this.dgvNarudzbaProizvodiV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbaProizvodiV.Size = new System.Drawing.Size(765, 387);
            this.dgvNarudzbaProizvodiV.TabIndex = 0;
            this.dgvNarudzbaProizvodiV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Proizvod
            // 
            this.Proizvod.DataPropertyName = "Proizvod";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Kolicina";
            dataGridViewCellStyle3.Format = "0 komada";
            dataGridViewCellStyle3.NullValue = null;
            this.Količina.DefaultCellStyle = dataGridViewCellStyle3;
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            dataGridViewCellStyle4.Format = "0.00 KM";
            dataGridViewCellStyle4.NullValue = null;
            this.Cijena.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // UkupnoPoProizvodu
            // 
            this.UkupnoPoProizvodu.DataPropertyName = "Ukupno";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "0.00 KM";
            dataGridViewCellStyle5.NullValue = null;
            this.UkupnoPoProizvodu.DefaultCellStyle = dataGridViewCellStyle5;
            this.UkupnoPoProizvodu.HeaderText = "UkupnoPoProizvodu";
            this.UkupnoPoProizvodu.Name = "UkupnoPoProizvodu";
            this.UkupnoPoProizvodu.ReadOnly = true;
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.ActiveImage = null;
            this.btnZavrsi.AllowAnimations = true;
            this.btnZavrsi.AllowBuffering = false;
            this.btnZavrsi.AllowToggling = false;
            this.btnZavrsi.AllowZooming = true;
            this.btnZavrsi.AllowZoomingOnFocus = false;
            this.btnZavrsi.BackColor = System.Drawing.Color.Transparent;
            this.btnZavrsi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnZavrsi.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnZavrsi.ErrorImage")));
            this.btnZavrsi.FadeWhenInactive = false;
            this.btnZavrsi.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnZavrsi.Image = ((System.Drawing.Image)(resources.GetObject("btnZavrsi.Image")));
            this.btnZavrsi.ImageActive = null;
            this.btnZavrsi.ImageLocation = null;
            this.btnZavrsi.ImageMargin = 40;
            this.btnZavrsi.ImageSize = new System.Drawing.Size(36, 37);
            this.btnZavrsi.ImageZoomSize = new System.Drawing.Size(76, 77);
            this.btnZavrsi.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnZavrsi.InitialImage")));
            this.btnZavrsi.Location = new System.Drawing.Point(670, 32);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Rotation = 0;
            this.btnZavrsi.ShowActiveImage = true;
            this.btnZavrsi.ShowCursorChanges = true;
            this.btnZavrsi.ShowImageBorders = true;
            this.btnZavrsi.ShowSizeMarkers = false;
            this.btnZavrsi.Size = new System.Drawing.Size(76, 77);
            this.btnZavrsi.TabIndex = 7;
            this.btnZavrsi.ToolTipText = "";
            this.btnZavrsi.Visible = false;
            this.btnZavrsi.WaitOnLoad = false;
            this.btnZavrsi.Zoom = 40;
            this.btnZavrsi.ZoomSpeed = 10;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.ActiveImage = null;
            this.btnPrihvati.AllowAnimations = true;
            this.btnPrihvati.AllowBuffering = false;
            this.btnPrihvati.AllowToggling = false;
            this.btnPrihvati.AllowZooming = true;
            this.btnPrihvati.AllowZoomingOnFocus = false;
            this.btnPrihvati.BackColor = System.Drawing.Color.Transparent;
            this.btnPrihvati.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrihvati.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPrihvati.ErrorImage")));
            this.btnPrihvati.FadeWhenInactive = false;
            this.btnPrihvati.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPrihvati.Image = ((System.Drawing.Image)(resources.GetObject("btnPrihvati.Image")));
            this.btnPrihvati.ImageActive = null;
            this.btnPrihvati.ImageLocation = null;
            this.btnPrihvati.ImageMargin = 40;
            this.btnPrihvati.ImageSize = new System.Drawing.Size(36, 37);
            this.btnPrihvati.ImageZoomSize = new System.Drawing.Size(76, 77);
            this.btnPrihvati.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrihvati.InitialImage")));
            this.btnPrihvati.Location = new System.Drawing.Point(670, 32);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Rotation = 0;
            this.btnPrihvati.ShowActiveImage = true;
            this.btnPrihvati.ShowCursorChanges = true;
            this.btnPrihvati.ShowImageBorders = true;
            this.btnPrihvati.ShowSizeMarkers = false;
            this.btnPrihvati.Size = new System.Drawing.Size(76, 77);
            this.btnPrihvati.TabIndex = 6;
            this.btnPrihvati.ToolTipText = "";
            this.btnPrihvati.WaitOnLoad = false;
            this.btnPrihvati.Zoom = 40;
            this.btnPrihvati.ZoomSpeed = 10;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.ActiveImage = null;
            this.btnOdbij.AllowAnimations = true;
            this.btnOdbij.AllowBuffering = false;
            this.btnOdbij.AllowToggling = false;
            this.btnOdbij.AllowZooming = true;
            this.btnOdbij.AllowZoomingOnFocus = false;
            this.btnOdbij.BackColor = System.Drawing.Color.Transparent;
            this.btnOdbij.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOdbij.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnOdbij.ErrorImage")));
            this.btnOdbij.FadeWhenInactive = false;
            this.btnOdbij.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnOdbij.Image = ((System.Drawing.Image)(resources.GetObject("btnOdbij.Image")));
            this.btnOdbij.ImageActive = null;
            this.btnOdbij.ImageLocation = null;
            this.btnOdbij.ImageMargin = 40;
            this.btnOdbij.ImageSize = new System.Drawing.Size(36, 37);
            this.btnOdbij.ImageZoomSize = new System.Drawing.Size(76, 77);
            this.btnOdbij.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnOdbij.InitialImage")));
            this.btnOdbij.Location = new System.Drawing.Point(588, 32);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Rotation = 0;
            this.btnOdbij.ShowActiveImage = true;
            this.btnOdbij.ShowCursorChanges = true;
            this.btnOdbij.ShowImageBorders = true;
            this.btnOdbij.ShowSizeMarkers = false;
            this.btnOdbij.Size = new System.Drawing.Size(76, 77);
            this.btnOdbij.TabIndex = 5;
            this.btnOdbij.ToolTipText = "";
            this.btnOdbij.WaitOnLoad = false;
            this.btnOdbij.Zoom = 40;
            this.btnOdbij.ZoomSpeed = 10;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AllowParentOverrides = false;
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.CursorType = null;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(351, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(66, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AllowParentOverrides = false;
            this.lblBrojTelefona.AutoEllipsis = false;
            this.lblBrojTelefona.CursorType = null;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblBrojTelefona.Location = new System.Drawing.Point(22, 101);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBrojTelefona.Size = new System.Drawing.Size(0, 0);
            this.lblBrojTelefona.TabIndex = 3;
            this.lblBrojTelefona.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBrojTelefona.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AllowParentOverrides = false;
            this.lblVrijeme.AutoEllipsis = false;
            this.lblVrijeme.CursorType = null;
            this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblVrijeme.Location = new System.Drawing.Point(22, 72);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVrijeme.Size = new System.Drawing.Size(0, 0);
            this.lblVrijeme.TabIndex = 2;
            this.lblVrijeme.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblVrijeme.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblVrijeme.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AllowParentOverrides = false;
            this.lblAdresa.AutoEllipsis = false;
            this.lblAdresa.CursorType = null;
            this.lblAdresa.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAdresa.ForeColor = System.Drawing.Color.Black;
            this.lblAdresa.Location = new System.Drawing.Point(22, 43);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAdresa.Size = new System.Drawing.Size(0, 0);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAdresa.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblIme
            // 
            this.lblIme.AllowParentOverrides = false;
            this.lblIme.AutoEllipsis = false;
            this.lblIme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIme.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblIme.Location = new System.Drawing.Point(22, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIme.Size = new System.Drawing.Size(0, 0);
            this.lblIme.TabIndex = 0;
            this.lblIme.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIme.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtPlacenoo
            // 
            this.txtPlacenoo.AutoSize = true;
            this.txtPlacenoo.Location = new System.Drawing.Point(503, 123);
            this.txtPlacenoo.Name = "txtPlacenoo";
            this.txtPlacenoo.Size = new System.Drawing.Size(0, 15);
            this.txtPlacenoo.TabIndex = 12;
            // 
            // frmNarudzbaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "frmNarudzbaDetalji";
            this.Text = "frmNarudzbaDetalji";
            this.Load += new System.EventHandler(this.frmNarudzbaDetalji_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.grpProizvodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbaProizvodiV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblAdresa;
        private Bunifu.UI.WinForms.BunifuLabel lblIme;
        private Bunifu.UI.WinForms.BunifuLabel lblVrijeme;
        private Bunifu.UI.WinForms.BunifuLabel lblBrojTelefona;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private Bunifu.UI.WinForms.BunifuImageButton btnPrihvati;
        private Bunifu.UI.WinForms.BunifuImageButton btnOdbij;
        private Bunifu.UI.WinForms.BunifuImageButton btnZavrsi;
        private Bunifu.UI.WinForms.BunifuGroupBox grpProizvodi;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNarudzbaProizvodiV;
        private Bunifu.UI.WinForms.BunifuLabel lblBAM;
        private Bunifu.UI.WinForms.BunifuLabel lblUkupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoPoProizvodu;
        private System.Windows.Forms.Label txtPaymentId;
        private System.Windows.Forms.Label txtPlacenoo;
    }
}