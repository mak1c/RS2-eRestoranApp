namespace eRestoran.WinUI.Izvjestaji
{
    partial class frmIzvjestaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvjestaj));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMjesecni = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblUcitavam = new Bunifu.UI.WinForms.BunifuLabel();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProdanih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaZarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Od:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AllowAnimations = true;
            this.button1.AllowMouseEffects = true;
            this.button1.AllowToggling = false;
            this.button1.AnimationSpeed = 200;
            this.button1.AutoGenerateColors = false;
            this.button1.AutoRoundBorders = false;
            this.button1.AutoSizeLeftIcon = true;
            this.button1.AutoSizeRightIcon = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.ButtonText = "Generiši";
            this.button1.ButtonTextMarginLeft = 0;
            this.button1.ColorContrastOnClick = 45;
            this.button1.ColorContrastOnHover = 45;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.button1.CustomizableEdges = borderEdges3;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button1.IconMarginLeft = 11;
            this.button1.IconPadding = 10;
            this.button1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button1.IconSize = 25;
            this.button1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.IdleBorderRadius = 1;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.button1.IdleIconLeftImage = null;
            this.button1.IdleIconRightImage = null;
            this.button1.IndicateFocus = false;
            this.button1.Location = new System.Drawing.Point(535, 38);
            this.button1.Name = "button1";
            this.button1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.OnDisabledState.BorderRadius = 1;
            this.button1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnDisabledState.BorderThickness = 1;
            this.button1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button1.OnDisabledState.IconLeftImage = null;
            this.button1.OnDisabledState.IconRightImage = null;
            this.button1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button1.onHoverState.BorderRadius = 1;
            this.button1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.onHoverState.BorderThickness = 1;
            this.button1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button1.onHoverState.IconLeftImage = null;
            this.button1.onHoverState.IconRightImage = null;
            this.button1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.OnIdleState.BorderRadius = 1;
            this.button1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnIdleState.BorderThickness = 1;
            this.button1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.button1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button1.OnIdleState.IconLeftImage = null;
            this.button1.OnIdleState.IconRightImage = null;
            this.button1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button1.OnPressedState.BorderRadius = 1;
            this.button1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnPressedState.BorderThickness = 1;
            this.button1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button1.OnPressedState.IconLeftImage = null;
            this.button1.OnPressedState.IconRightImage = null;
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.TextMarginLeft = 0;
            this.button1.TextPadding = new System.Windows.Forms.Padding(0);
            this.button1.UseDefaultRadiusAndThickness = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.BrojProdanih,
            this.UkupnaZarada});
            this.dataGridView1.Location = new System.Drawing.Point(15, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 312);
            this.dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ukupna zarada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(130, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 11;
            // 
            // btnMjesecni
            // 
            this.btnMjesecni.AllowAnimations = true;
            this.btnMjesecni.AllowMouseEffects = true;
            this.btnMjesecni.AllowToggling = false;
            this.btnMjesecni.AnimationSpeed = 200;
            this.btnMjesecni.AutoGenerateColors = false;
            this.btnMjesecni.AutoRoundBorders = false;
            this.btnMjesecni.AutoSizeLeftIcon = true;
            this.btnMjesecni.AutoSizeRightIcon = true;
            this.btnMjesecni.BackColor = System.Drawing.Color.Transparent;
            this.btnMjesecni.BackColor1 = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMjesecni.BackgroundImage")));
            this.btnMjesecni.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMjesecni.ButtonText = "Izvještaj prodaje po mjesecima";
            this.btnMjesecni.ButtonTextMarginLeft = 0;
            this.btnMjesecni.ColorContrastOnClick = 45;
            this.btnMjesecni.ColorContrastOnHover = 45;
            this.btnMjesecni.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnMjesecni.CustomizableEdges = borderEdges4;
            this.btnMjesecni.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMjesecni.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMjesecni.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMjesecni.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMjesecni.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMjesecni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMjesecni.ForeColor = System.Drawing.Color.White;
            this.btnMjesecni.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMjesecni.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMjesecni.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMjesecni.IconMarginLeft = 11;
            this.btnMjesecni.IconPadding = 10;
            this.btnMjesecni.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMjesecni.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMjesecni.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMjesecni.IconSize = 25;
            this.btnMjesecni.IdleBorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.IdleBorderRadius = 1;
            this.btnMjesecni.IdleBorderThickness = 1;
            this.btnMjesecni.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.IdleIconLeftImage = null;
            this.btnMjesecni.IdleIconRightImage = null;
            this.btnMjesecni.IndicateFocus = false;
            this.btnMjesecni.Location = new System.Drawing.Point(464, 448);
            this.btnMjesecni.Name = "btnMjesecni";
            this.btnMjesecni.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMjesecni.OnDisabledState.BorderRadius = 1;
            this.btnMjesecni.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMjesecni.OnDisabledState.BorderThickness = 1;
            this.btnMjesecni.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMjesecni.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMjesecni.OnDisabledState.IconLeftImage = null;
            this.btnMjesecni.OnDisabledState.IconRightImage = null;
            this.btnMjesecni.onHoverState.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.onHoverState.BorderRadius = 1;
            this.btnMjesecni.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMjesecni.onHoverState.BorderThickness = 1;
            this.btnMjesecni.onHoverState.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMjesecni.onHoverState.IconLeftImage = null;
            this.btnMjesecni.onHoverState.IconRightImage = null;
            this.btnMjesecni.OnIdleState.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.OnIdleState.BorderRadius = 1;
            this.btnMjesecni.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMjesecni.OnIdleState.BorderThickness = 1;
            this.btnMjesecni.OnIdleState.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnMjesecni.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMjesecni.OnIdleState.IconLeftImage = null;
            this.btnMjesecni.OnIdleState.IconRightImage = null;
            this.btnMjesecni.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMjesecni.OnPressedState.BorderRadius = 1;
            this.btnMjesecni.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMjesecni.OnPressedState.BorderThickness = 1;
            this.btnMjesecni.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMjesecni.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMjesecni.OnPressedState.IconLeftImage = null;
            this.btnMjesecni.OnPressedState.IconRightImage = null;
            this.btnMjesecni.Size = new System.Drawing.Size(221, 39);
            this.btnMjesecni.TabIndex = 12;
            this.btnMjesecni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMjesecni.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMjesecni.TextMarginLeft = 0;
            this.btnMjesecni.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMjesecni.UseDefaultRadiusAndThickness = true;
            this.btnMjesecni.Click += new System.EventHandler(this.btnMjesecni_Click);
            // 
            // lblUcitavam
            // 
            this.lblUcitavam.AllowParentOverrides = false;
            this.lblUcitavam.AutoEllipsis = false;
            this.lblUcitavam.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUcitavam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUcitavam.Location = new System.Drawing.Point(306, 74);
            this.lblUcitavam.Name = "lblUcitavam";
            this.lblUcitavam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUcitavam.Size = new System.Drawing.Size(0, 0);
            this.lblUcitavam.TabIndex = 13;
            this.lblUcitavam.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUcitavam.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojProdanih
            // 
            this.BrojProdanih.DataPropertyName = "BrojProdanih";
            this.BrojProdanih.HeaderText = "Broj prodanih";
            this.BrojProdanih.Name = "BrojProdanih";
            this.BrojProdanih.ReadOnly = true;
            // 
            // UkupnaZarada
            // 
            this.UkupnaZarada.DataPropertyName = "UkupnaZarada";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "0.00 KM";
            dataGridViewCellStyle2.NullValue = null;
            this.UkupnaZarada.DefaultCellStyle = dataGridViewCellStyle2;
            this.UkupnaZarada.HeaderText = "Zarada";
            this.UkupnaZarada.Name = "UkupnaZarada";
            this.UkupnaZarada.ReadOnly = true;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.lblUcitavam);
            this.Controls.Add(this.btnMjesecni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmIzvjestaj";
            this.Text = "frmIzvjestajKategorije";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMjesecni;
        private Bunifu.UI.WinForms.BunifuLabel lblUcitavam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProdanih;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaZarada;
    }
}