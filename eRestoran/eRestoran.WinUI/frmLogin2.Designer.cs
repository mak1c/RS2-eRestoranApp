using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace eRestoran.WinUI
{
    partial class frmLogin2
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
        /// 
       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrijava = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btnPrijava);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 536);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnPrijava
            // 
            this.btnPrijava.AllowAnimations = true;
            this.btnPrijava.AllowMouseEffects = true;
            this.btnPrijava.AllowToggling = false;
            this.btnPrijava.AnimationSpeed = 200;
            this.btnPrijava.AutoGenerateColors = false;
            this.btnPrijava.AutoRoundBorders = false;
            this.btnPrijava.AutoSizeLeftIcon = true;
            this.btnPrijava.AutoSizeRightIcon = true;
            this.btnPrijava.BackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.BackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrijava.BackgroundImage")));
            this.btnPrijava.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.ButtonText = "Prijava";
            this.btnPrijava.ButtonTextMarginLeft = 0;
            this.btnPrijava.ColorContrastOnClick = 45;
            this.btnPrijava.ColorContrastOnHover = 45;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrijava.CustomizableEdges = borderEdges1;
            this.btnPrijava.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrijava.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrijava.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrijava.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrijava.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrijava.IconMarginLeft = 11;
            this.btnPrijava.IconPadding = 10;
            this.btnPrijava.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrijava.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrijava.IconSize = 25;
            this.btnPrijava.IdleBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.IdleBorderRadius = 1;
            this.btnPrijava.IdleBorderThickness = 1;
            this.btnPrijava.IdleFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.IdleIconLeftImage = null;
            this.btnPrijava.IdleIconRightImage = null;
            this.btnPrijava.IndicateFocus = false;
            this.btnPrijava.Location = new System.Drawing.Point(276, 271);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrijava.OnDisabledState.BorderRadius = 1;
            this.btnPrijava.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnDisabledState.BorderThickness = 1;
            this.btnPrijava.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrijava.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrijava.OnDisabledState.IconLeftImage = null;
            this.btnPrijava.OnDisabledState.IconRightImage = null;
            this.btnPrijava.onHoverState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.onHoverState.BorderRadius = 1;
            this.btnPrijava.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.onHoverState.BorderThickness = 1;
            this.btnPrijava.onHoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.onHoverState.IconLeftImage = null;
            this.btnPrijava.onHoverState.IconRightImage = null;
            this.btnPrijava.OnIdleState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.OnIdleState.BorderRadius = 1;
            this.btnPrijava.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnIdleState.BorderThickness = 1;
            this.btnPrijava.OnIdleState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijava.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnIdleState.IconLeftImage = null;
            this.btnPrijava.OnIdleState.IconRightImage = null;
            this.btnPrijava.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrijava.OnPressedState.BorderRadius = 1;
            this.btnPrijava.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrijava.OnPressedState.BorderThickness = 1;
            this.btnPrijava.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrijava.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.OnPressedState.IconLeftImage = null;
            this.btnPrijava.OnPressedState.IconRightImage = null;
            this.btnPrijava.Size = new System.Drawing.Size(260, 46);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrijava.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrijava.TextMarginLeft = 0;
            this.btnPrijava.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrijava.UseDefaultRadiusAndThickness = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.BlueViolet;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Indigo;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(276, 216);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.BlueViolet;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Indigo;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(260, 37);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AnimationSpeed = 200;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsername.BackgroundImage")));
            this.txtUsername.BorderColorActive = System.Drawing.Color.BlueViolet;
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.Indigo;
            this.txtUsername.BorderRadius = 1;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = null;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(276, 162);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Modified = false;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            stateProperties5.BorderColor = System.Drawing.Color.BlueViolet;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Indigo;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsername.OnIdleState = stateProperties8;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(3);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(260, 37);
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginBottom = 0;
            this.txtUsername.TextMarginLeft = 3;
            this.txtUsername.TextMarginTop = 0;
            this.txtUsername.TextPlaceholder = "Username";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WordWrap = true;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(-20, -20);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(775, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuLabel1
            // 
         
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Plum;
            this.bunifuLabel1.Location = new System.Drawing.Point(348, 323);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(88, 21);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin2";
            this.Text = "Login2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }


      

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrijava;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}