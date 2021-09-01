namespace eRestoran.WinUI.Korisnici
{
    partial class frmKlijenti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlijenti));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dgv_klijenti = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isključen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnPretragaKlijenata = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPrezime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtIme = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGroupBox1.SuspendLayout();
            this.bunifuGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klijenti)).BeginInit();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.bunifuGroupBox3);
            this.bunifuGroupBox1.Controls.Add(this.bunifuGroupBox2);
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(800, 519);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox3.BorderRadius = 1;
            this.bunifuGroupBox3.BorderThickness = 1;
            this.bunifuGroupBox3.Controls.Add(this.dgv_klijenti);
            this.bunifuGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(3, 70);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(794, 443);
            this.bunifuGroupBox3.TabIndex = 1;
            this.bunifuGroupBox3.TabStop = false;
            this.bunifuGroupBox3.Text = "Klijenti";
            // 
            // dgv_klijenti
            // 
            this.dgv_klijenti.AllowCustomTheming = false;
            this.dgv_klijenti.AllowUserToAddRows = false;
            this.dgv_klijenti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_klijenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_klijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klijenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_klijenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_klijenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_klijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_klijenti.ColumnHeadersHeight = 40;
            this.dgv_klijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Status,
            this.Telefon,
            this.Email,
            this.Isključen});
            this.dgv_klijenti.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_klijenti.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_klijenti.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_klijenti.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_klijenti.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_klijenti.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_klijenti.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_klijenti.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_klijenti.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_klijenti.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_klijenti.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_klijenti.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_klijenti.CurrentTheme.Name = null;
            this.dgv_klijenti.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_klijenti.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_klijenti.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_klijenti.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_klijenti.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_klijenti.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_klijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_klijenti.EnableHeadersVisualStyles = false;
            this.dgv_klijenti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_klijenti.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_klijenti.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_klijenti.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_klijenti.Location = new System.Drawing.Point(3, 19);
            this.dgv_klijenti.Name = "dgv_klijenti";
            this.dgv_klijenti.ReadOnly = true;
            this.dgv_klijenti.RowHeadersVisible = false;
            this.dgv_klijenti.RowTemplate.Height = 40;
            this.dgv_klijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_klijenti.Size = new System.Drawing.Size(788, 421);
            this.dgv_klijenti.TabIndex = 0;
            this.dgv_klijenti.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_klijenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_klijenti_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "KorisnikId";
            this.Id.FillWeight = 66.96899F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.FillWeight = 115.9312F;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.FillWeight = 117.9566F;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 60.9531F;
            this.Status.HeaderText = "Aktivan?";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.FillWeight = 140.7184F;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 126.4056F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Isključen
            // 
            this.Isključen.FillWeight = 71.06598F;
            this.Isključen.HeaderText = "Opcije";
            this.Isključen.Name = "Isključen";
            this.Isključen.ReadOnly = true;
            this.Isključen.Text = "On/Off";
            this.Isključen.UseColumnTextForButtonValue = true;
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.btnPretragaKlijenata);
            this.bunifuGroupBox2.Controls.Add(this.txtPrezime);
            this.bunifuGroupBox2.Controls.Add(this.txtIme);
            this.bunifuGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(3, 19);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(794, 51);
            this.bunifuGroupBox2.TabIndex = 0;
            this.bunifuGroupBox2.TabStop = false;
            // 
            // btnPretragaKlijenata
            // 
            this.btnPretragaKlijenata.AllowAnimations = true;
            this.btnPretragaKlijenata.AllowMouseEffects = true;
            this.btnPretragaKlijenata.AllowToggling = false;
            this.btnPretragaKlijenata.AnimationSpeed = 200;
            this.btnPretragaKlijenata.AutoGenerateColors = false;
            this.btnPretragaKlijenata.AutoRoundBorders = false;
            this.btnPretragaKlijenata.AutoSizeLeftIcon = true;
            this.btnPretragaKlijenata.AutoSizeRightIcon = true;
            this.btnPretragaKlijenata.BackColor = System.Drawing.Color.Transparent;
            this.btnPretragaKlijenata.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPretragaKlijenata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPretragaKlijenata.BackgroundImage")));
            this.btnPretragaKlijenata.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretragaKlijenata.ButtonText = "Traži";
            this.btnPretragaKlijenata.ButtonTextMarginLeft = 0;
            this.btnPretragaKlijenata.ColorContrastOnClick = 45;
            this.btnPretragaKlijenata.ColorContrastOnHover = 45;
            this.btnPretragaKlijenata.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPretragaKlijenata.CustomizableEdges = borderEdges1;
            this.btnPretragaKlijenata.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPretragaKlijenata.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPretragaKlijenata.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPretragaKlijenata.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPretragaKlijenata.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPretragaKlijenata.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPretragaKlijenata.ForeColor = System.Drawing.Color.White;
            this.btnPretragaKlijenata.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretragaKlijenata.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPretragaKlijenata.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPretragaKlijenata.IconMarginLeft = 11;
            this.btnPretragaKlijenata.IconPadding = 10;
            this.btnPretragaKlijenata.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPretragaKlijenata.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPretragaKlijenata.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPretragaKlijenata.IconSize = 25;
            this.btnPretragaKlijenata.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPretragaKlijenata.IdleBorderRadius = 1;
            this.btnPretragaKlijenata.IdleBorderThickness = 1;
            this.btnPretragaKlijenata.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPretragaKlijenata.IdleIconLeftImage = null;
            this.btnPretragaKlijenata.IdleIconRightImage = null;
            this.btnPretragaKlijenata.IndicateFocus = false;
            this.btnPretragaKlijenata.Location = new System.Drawing.Point(302, 4);
            this.btnPretragaKlijenata.Name = "btnPretragaKlijenata";
            this.btnPretragaKlijenata.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPretragaKlijenata.OnDisabledState.BorderRadius = 1;
            this.btnPretragaKlijenata.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretragaKlijenata.OnDisabledState.BorderThickness = 1;
            this.btnPretragaKlijenata.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPretragaKlijenata.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPretragaKlijenata.OnDisabledState.IconLeftImage = null;
            this.btnPretragaKlijenata.OnDisabledState.IconRightImage = null;
            this.btnPretragaKlijenata.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPretragaKlijenata.onHoverState.BorderRadius = 1;
            this.btnPretragaKlijenata.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretragaKlijenata.onHoverState.BorderThickness = 1;
            this.btnPretragaKlijenata.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPretragaKlijenata.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPretragaKlijenata.onHoverState.IconLeftImage = null;
            this.btnPretragaKlijenata.onHoverState.IconRightImage = null;
            this.btnPretragaKlijenata.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPretragaKlijenata.OnIdleState.BorderRadius = 1;
            this.btnPretragaKlijenata.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretragaKlijenata.OnIdleState.BorderThickness = 1;
            this.btnPretragaKlijenata.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPretragaKlijenata.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPretragaKlijenata.OnIdleState.IconLeftImage = null;
            this.btnPretragaKlijenata.OnIdleState.IconRightImage = null;
            this.btnPretragaKlijenata.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPretragaKlijenata.OnPressedState.BorderRadius = 1;
            this.btnPretragaKlijenata.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPretragaKlijenata.OnPressedState.BorderThickness = 1;
            this.btnPretragaKlijenata.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPretragaKlijenata.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPretragaKlijenata.OnPressedState.IconLeftImage = null;
            this.btnPretragaKlijenata.OnPressedState.IconRightImage = null;
            this.btnPretragaKlijenata.Size = new System.Drawing.Size(75, 39);
            this.btnPretragaKlijenata.TabIndex = 2;
            this.btnPretragaKlijenata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPretragaKlijenata.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPretragaKlijenata.TextMarginLeft = 0;
            this.btnPretragaKlijenata.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPretragaKlijenata.UseDefaultRadiusAndThickness = true;
            this.btnPretragaKlijenata.Click += new System.EventHandler(this.btnPretragaKlijenata_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.AcceptsReturn = false;
            this.txtPrezime.AcceptsTab = false;
            this.txtPrezime.AnimationSpeed = 200;
            this.txtPrezime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrezime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrezime.BackColor = System.Drawing.Color.Transparent;
            this.txtPrezime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrezime.BackgroundImage")));
            this.txtPrezime.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPrezime.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrezime.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPrezime.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPrezime.BorderRadius = 1;
            this.txtPrezime.BorderThickness = 1;
            this.txtPrezime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrezime.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPrezime.DefaultText = "";
            this.txtPrezime.FillColor = System.Drawing.Color.White;
            this.txtPrezime.HideSelection = true;
            this.txtPrezime.IconLeft = null;
            this.txtPrezime.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrezime.IconPadding = 10;
            this.txtPrezime.IconRight = null;
            this.txtPrezime.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(155, 3);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPrezime.Modified = false;
            this.txtPrezime.Multiline = false;
            this.txtPrezime.Name = "txtPrezime";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrezime.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPrezime.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrezime.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrezime.OnIdleState = stateProperties4;
            this.txtPrezime.Padding = new System.Windows.Forms.Padding(3);
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPrezime.PlaceholderText = "Ime";
            this.txtPrezime.ReadOnly = false;
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(140, 37);
            this.txtPrezime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrezime.TextMarginBottom = 0;
            this.txtPrezime.TextMarginLeft = 3;
            this.txtPrezime.TextMarginTop = 0;
            this.txtPrezime.TextPlaceholder = "Ime";
            this.txtPrezime.UseSystemPasswordChar = false;
            this.txtPrezime.WordWrap = true;
            // 
            // txtIme
            // 
            this.txtIme.AcceptsReturn = false;
            this.txtIme.AcceptsTab = false;
            this.txtIme.AnimationSpeed = 200;
            this.txtIme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIme.BackColor = System.Drawing.Color.Transparent;
            this.txtIme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIme.BackgroundImage")));
            this.txtIme.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtIme.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIme.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtIme.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtIme.BorderRadius = 1;
            this.txtIme.BorderThickness = 1;
            this.txtIme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIme.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtIme.DefaultText = "";
            this.txtIme.FillColor = System.Drawing.Color.White;
            this.txtIme.HideSelection = true;
            this.txtIme.IconLeft = null;
            this.txtIme.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIme.IconPadding = 10;
            this.txtIme.IconRight = null;
            this.txtIme.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(9, 3);
            this.txtIme.MaxLength = 32767;
            this.txtIme.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIme.Modified = false;
            this.txtIme.Multiline = false;
            this.txtIme.Name = "txtIme";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIme.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtIme.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIme.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIme.OnIdleState = stateProperties8;
            this.txtIme.Padding = new System.Windows.Forms.Padding(3);
            this.txtIme.PasswordChar = '\0';
            this.txtIme.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIme.PlaceholderText = "Ime";
            this.txtIme.ReadOnly = false;
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(140, 37);
            this.txtIme.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtIme.TabIndex = 0;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIme.TextMarginBottom = 0;
            this.txtIme.TextMarginLeft = 3;
            this.txtIme.TextMarginTop = 0;
            this.txtIme.TextPlaceholder = "Ime";
            this.txtIme.UseSystemPasswordChar = false;
            this.txtIme.WordWrap = true;
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Name = "frmKlijenti";
            this.Text = "frmKlijenti";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klijenti)).EndInit();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuTextBox txtIme;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_klijenti;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPretragaKlijenata;
        private Bunifu.UI.WinForms.BunifuTextBox txtPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Isključen;
    }
}