namespace eRestoran.WinUI.Proizvodi
{
    partial class ProizvodItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProizvodItem));
            this.pictureBoxx = new System.Windows.Forms.PictureBox();
            this.label2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxx
            // 
            this.pictureBoxx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxx.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxx.Image")));
            this.pictureBoxx.Location = new System.Drawing.Point(218, 8);
            this.pictureBoxx.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxx.Name = "pictureBoxx";
            this.pictureBoxx.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBoxx.Size = new System.Drawing.Size(38, 34);
            this.pictureBoxx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxx.TabIndex = 0;
            this.pictureBoxx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AllowParentOverrides = false;
            this.label2.AutoEllipsis = false;
            this.label2.CursorType = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(109, 169);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roštilj";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ProizvodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Purple;
            this.BorderRadius = 10;
            this.BorderThickness = 2;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxx);
            this.Name = "ProizvodItem";
            this.Size = new System.Drawing.Size(269, 222);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxx;
        private Bunifu.UI.WinForms.BunifuLabel label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
