using System.Drawing;

namespace eRestoran.WinUI.Narudzbe
{
    partial class frmNarudzbe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzbe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dgvNarudzbe = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cmbStatusNarudzbe = new System.Windows.Forms.ComboBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dateNarudzbe = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuGroupBox1.SuspendLayout();
            this.bunifuGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.bunifuGroupBox3);
            this.bunifuGroupBox1.Controls.Add(this.bunifuGroupBox2);
            this.bunifuGroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(800, 501);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox3.BorderRadius = 1;
            this.bunifuGroupBox3.BorderThickness = 1;
            this.bunifuGroupBox3.Controls.Add(this.dgvNarudzbe);
            this.bunifuGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(3, 102);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(794, 393);
            this.bunifuGroupBox3.TabIndex = 1;
            this.bunifuGroupBox3.TabStop = false;
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowCustomTheming = false;
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNarudzbe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNarudzbe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNarudzbe.ColumnHeadersHeight = 40;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KorisnikId,
            this.Od,
            this.Lokacija,
            this.Vrijeme,
            this.BrojTelefona,
            this.Status,
            this.Detalji});
            this.dgvNarudzbe.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNarudzbe.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbe.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbe.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNarudzbe.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbe.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNarudzbe.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNarudzbe.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNarudzbe.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbe.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNarudzbe.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNarudzbe.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNarudzbe.CurrentTheme.Name = null;
            this.dgvNarudzbe.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNarudzbe.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNarudzbe.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbe.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNarudzbe.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbe.EnableHeadersVisualStyles = false;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNarudzbe.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNarudzbe.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNarudzbe.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNarudzbe.Location = new System.Drawing.Point(3, 19);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersVisible = false;
            this.dgvNarudzbe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvNarudzbe.RowTemplate.Height = 40;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(788, 371);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "NarudzbeId";
            this.Id.FillWeight = 80F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.ToolTipText = "Id";
            this.Id.Width = 80;
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // Od
            // 
            this.Od.DataPropertyName = "korisnik";
            this.Od.FillWeight = 75.21151F;
            this.Od.HeaderText = "Od";
            this.Od.Name = "Od";
            this.Od.ReadOnly = true;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "adresa";
            this.Lokacija.FillWeight = 75.21151F;
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "datumNarudžbe";
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.Vrijeme.DefaultCellStyle = dataGridViewCellStyle7;
            this.Vrijeme.FillWeight = 75.21151F;
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrojTelefona.DataPropertyName = "brojTelefona";
            this.BrojTelefona.FillWeight = 85F;
            this.BrojTelefona.HeaderText = "Broj telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.ReadOnly = true;
            this.BrojTelefona.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "NarudzbaStatus";
            this.Status.FillWeight = 75.21151F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.FillWeight = 75.21151F;
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.label1);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCheckBox1);
            this.bunifuGroupBox2.Controls.Add(this.cmbStatusNarudzbe);
            this.bunifuGroupBox2.Controls.Add(this.bunifuImageButton1);
            this.bunifuGroupBox2.Controls.Add(this.bunifuButton1);
            this.bunifuGroupBox2.Controls.Add(this.dateNarudzbe);
            this.bunifuGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(3, 19);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(794, 83);
            this.bunifuGroupBox2.TabIndex = 0;
            this.bunifuGroupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraga po datumu?";
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(218, 51);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 5;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // cmbStatusNarudzbe
            // 
            this.cmbStatusNarudzbe.FormattingEnabled = true;
            this.cmbStatusNarudzbe.Items.AddRange(new object[] {
            "Na čekanju",
            "Prihvaćen",
            "Gotovo"});
            this.cmbStatusNarudzbe.Location = new System.Drawing.Point(9, 16);
            this.cmbStatusNarudzbe.Name = "cmbStatusNarudzbe";
            this.cmbStatusNarudzbe.Size = new System.Drawing.Size(194, 23);
            this.cmbStatusNarudzbe.TabIndex = 4;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(35, 34);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(75, 74);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(700, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(75, 74);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Traži";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(369, 16);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(116, 61);
            this.bunifuButton1.TabIndex = 2;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // dateNarudzbe
            // 
            this.dateNarudzbe.BackColor = System.Drawing.Color.Transparent;
            this.dateNarudzbe.BorderRadius = 1;
            this.dateNarudzbe.Color = System.Drawing.Color.Silver;
            this.dateNarudzbe.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateNarudzbe.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateNarudzbe.DisabledColor = System.Drawing.Color.Gray;
            this.dateNarudzbe.DisplayWeekNumbers = false;
            this.dateNarudzbe.DPHeight = 0;
            this.dateNarudzbe.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNarudzbe.FillDatePicker = false;
            this.dateNarudzbe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNarudzbe.ForeColor = System.Drawing.Color.Black;
            this.dateNarudzbe.Icon = ((System.Drawing.Image)(resources.GetObject("dateNarudzbe.Icon")));
            this.dateNarudzbe.IconColor = System.Drawing.Color.Gray;
            this.dateNarudzbe.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateNarudzbe.LeftTextMargin = 5;
            this.dateNarudzbe.Location = new System.Drawing.Point(9, 45);
            this.dateNarudzbe.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateNarudzbe.Name = "dateNarudzbe";
            this.dateNarudzbe.Size = new System.Drawing.Size(194, 32);
            this.dateNarudzbe.TabIndex = 1;
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "frmNarudzbe";
            this.Text = "frmNarudzbe";
            this.Load += new System.EventHandler(this.frmNarudzbe_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNarudzbe;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDatePicker dateNarudzbe;
        private System.Windows.Forms.ComboBox cmbStatusNarudzbe;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}