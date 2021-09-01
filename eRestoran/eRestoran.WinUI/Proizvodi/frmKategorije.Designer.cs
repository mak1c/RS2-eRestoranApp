
namespace eRestoran.WinUI.Proizvodi
{
    partial class frmKategorije
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorije));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKategorije = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNaziv = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtOpis = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtSlika = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(580, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 177);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKategorije);
            this.groupBox1.Location = new System.Drawing.Point(22, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 316);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorije proizvoda";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowCustomTheming = false;
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvKategorije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKategorije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategorije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKategorije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKategorije.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategorije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategorije.ColumnHeadersHeight = 40;
            this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Slika,
            this.Uredi,
            this.Obriši});
            this.dgvKategorije.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvKategorije.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKategorije.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKategorije.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvKategorije.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKategorije.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKategorije.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvKategorije.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKategorije.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvKategorije.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKategorije.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvKategorije.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvKategorije.CurrentTheme.Name = null;
            this.dgvKategorije.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvKategorije.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKategorije.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKategorije.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvKategorije.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategorije.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKategorije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKategorije.EnableHeadersVisualStyles = false;
            this.dgvKategorije.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvKategorije.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKategorije.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvKategorije.HeaderForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.dgvKategorije, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.dgvKategorije.Location = new System.Drawing.Point(3, 16);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.RowHeadersVisible = false;
            this.dgvKategorije.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvKategorije.RowTemplate.Height = 40;
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(900, 297);
            this.dgvKategorije.TabIndex = 0;
            this.dgvKategorije.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvKategorije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategorije_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "KategorijaId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "";
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.AcceptsReturn = false;
            this.txtNaziv.AcceptsTab = false;
            this.txtNaziv.AnimationSpeed = 200;
            this.txtNaziv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNaziv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNaziv.BackColor = System.Drawing.Color.Transparent;
            this.txtNaziv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNaziv.BackgroundImage")));
            this.txtNaziv.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNaziv.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNaziv.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNaziv.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNaziv.BorderRadius = 1;
            this.txtNaziv.BorderThickness = 1;
            this.txtNaziv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNaziv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaziv.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNaziv.DefaultText = "";
            this.txtNaziv.FillColor = System.Drawing.Color.White;
            this.txtNaziv.HideSelection = true;
            this.txtNaziv.IconLeft = null;
            this.txtNaziv.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaziv.IconPadding = 10;
            this.txtNaziv.IconRight = null;
            this.txtNaziv.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaziv.Lines = new string[0];
            this.txtNaziv.Location = new System.Drawing.Point(153, 10);
            this.txtNaziv.MaxLength = 32767;
            this.txtNaziv.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNaziv.Modified = false;
            this.txtNaziv.Multiline = false;
            this.txtNaziv.Name = "txtNaziv";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNaziv.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNaziv.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNaziv.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNaziv.OnIdleState = stateProperties12;
            this.txtNaziv.Padding = new System.Windows.Forms.Padding(3);
            this.txtNaziv.PasswordChar = '\0';
            this.txtNaziv.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNaziv.PlaceholderText = "Naziv";
            this.txtNaziv.ReadOnly = false;
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNaziv.SelectedText = "";
            this.txtNaziv.SelectionLength = 0;
            this.txtNaziv.SelectionStart = 0;
            this.txtNaziv.ShortcutsEnabled = true;
            this.txtNaziv.Size = new System.Drawing.Size(260, 37);
            this.txtNaziv.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNaziv.TabIndex = 12;
            this.txtNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNaziv.TextMarginBottom = 0;
            this.txtNaziv.TextMarginLeft = 3;
            this.txtNaziv.TextMarginTop = 0;
            this.txtNaziv.TextPlaceholder = "Naziv";
            this.txtNaziv.UseSystemPasswordChar = false;
            this.txtNaziv.WordWrap = true;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtOpis
            // 
            this.txtOpis.AcceptsReturn = false;
            this.txtOpis.AcceptsTab = false;
            this.txtOpis.AnimationSpeed = 200;
            this.txtOpis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOpis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOpis.BackColor = System.Drawing.Color.Transparent;
            this.txtOpis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtOpis.BackgroundImage")));
            this.txtOpis.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtOpis.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOpis.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtOpis.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtOpis.BorderRadius = 1;
            this.txtOpis.BorderThickness = 1;
            this.txtOpis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOpis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpis.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtOpis.DefaultText = "";
            this.txtOpis.FillColor = System.Drawing.Color.White;
            this.txtOpis.HideSelection = true;
            this.txtOpis.IconLeft = null;
            this.txtOpis.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpis.IconPadding = 10;
            this.txtOpis.IconRight = null;
            this.txtOpis.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpis.Lines = new string[0];
            this.txtOpis.Location = new System.Drawing.Point(153, 53);
            this.txtOpis.MaxLength = 32767;
            this.txtOpis.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOpis.Modified = false;
            this.txtOpis.Multiline = false;
            this.txtOpis.Name = "txtOpis";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOpis.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtOpis.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOpis.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtOpis.OnIdleState = stateProperties8;
            this.txtOpis.Padding = new System.Windows.Forms.Padding(3);
            this.txtOpis.PasswordChar = '\0';
            this.txtOpis.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtOpis.PlaceholderText = "Opis";
            this.txtOpis.ReadOnly = false;
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpis.SelectedText = "";
            this.txtOpis.SelectionLength = 0;
            this.txtOpis.SelectionStart = 0;
            this.txtOpis.ShortcutsEnabled = true;
            this.txtOpis.Size = new System.Drawing.Size(260, 93);
            this.txtOpis.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtOpis.TabIndex = 13;
            this.txtOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOpis.TextMarginBottom = 0;
            this.txtOpis.TextMarginLeft = 3;
            this.txtOpis.TextMarginTop = 0;
            this.txtOpis.TextPlaceholder = "Opis";
            this.txtOpis.UseSystemPasswordChar = false;
            this.txtOpis.WordWrap = true;
            // 
            // txtSlika
            // 
            this.txtSlika.AcceptsReturn = false;
            this.txtSlika.AcceptsTab = false;
            this.txtSlika.AnimationSpeed = 200;
            this.txtSlika.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSlika.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSlika.BackColor = System.Drawing.Color.Transparent;
            this.txtSlika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSlika.BackgroundImage")));
            this.txtSlika.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSlika.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSlika.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSlika.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSlika.BorderRadius = 1;
            this.txtSlika.BorderThickness = 1;
            this.txtSlika.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSlika.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlika.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSlika.DefaultText = "";
            this.txtSlika.FillColor = System.Drawing.Color.White;
            this.txtSlika.HideSelection = true;
            this.txtSlika.IconLeft = null;
            this.txtSlika.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlika.IconPadding = 10;
            this.txtSlika.IconRight = null;
            this.txtSlika.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlika.Lines = new string[0];
            this.txtSlika.Location = new System.Drawing.Point(153, 150);
            this.txtSlika.MaxLength = 32767;
            this.txtSlika.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSlika.Modified = false;
            this.txtSlika.Multiline = false;
            this.txtSlika.Name = "txtSlika";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSlika.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSlika.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSlika.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSlika.OnIdleState = stateProperties4;
            this.txtSlika.Padding = new System.Windows.Forms.Padding(3);
            this.txtSlika.PasswordChar = '\0';
            this.txtSlika.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSlika.PlaceholderText = "Slika";
            this.txtSlika.ReadOnly = false;
            this.txtSlika.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlika.SelectedText = "";
            this.txtSlika.SelectionLength = 0;
            this.txtSlika.SelectionStart = 0;
            this.txtSlika.ShortcutsEnabled = true;
            this.txtSlika.Size = new System.Drawing.Size(260, 37);
            this.txtSlika.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSlika.TabIndex = 14;
            this.txtSlika.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSlika.TextMarginBottom = 0;
            this.txtSlika.TextMarginLeft = 3;
            this.txtSlika.TextMarginTop = 0;
            this.txtSlika.TextPlaceholder = "Slika";
            this.txtSlika.UseSystemPasswordChar = false;
            this.txtSlika.WordWrap = true;
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
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DarkViolet;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Odaberi";
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
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DarkViolet;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DarkViolet;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(420, 150);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.MediumOrchid;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.MediumOrchid;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DarkViolet;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DarkViolet;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Purple;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Purple;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(81, 37);
            this.bunifuButton1.TabIndex = 15;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Spremi";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(153, 195);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(606, 39);
            this.bunifuButton2.TabIndex = 16;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "frmKategorije";
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmKategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvKategorije;
        private Bunifu.UI.WinForms.BunifuTextBox txtNaziv;
        private Bunifu.UI.WinForms.BunifuTextBox txtOpis;
        private Bunifu.UI.WinForms.BunifuTextBox txtSlika;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
    }
}