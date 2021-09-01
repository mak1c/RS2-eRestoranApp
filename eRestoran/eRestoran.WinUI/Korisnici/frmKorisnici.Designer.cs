
namespace eRestoran.WinUI.Obavijest
{
    partial class frmKorisnici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btn_Prikazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijesti);
            this.groupBox1.Location = new System.Drawing.Point(22, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1423, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijesti.Location = new System.Drawing.Point(6, 28);
            this.dgvObavijesti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowHeadersWidth = 72;
            this.dgvObavijesti.Size = new System.Drawing.Size(1411, 649);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(22, 65);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(516, 29);
            this.txtPretraga.TabIndex = 1;
            // 
            // btn_Prikazi
            // 
            this.btn_Prikazi.Location = new System.Drawing.Point(1307, 59);
            this.btn_Prikazi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Prikazi.Name = "btn_Prikazi";
            this.btn_Prikazi.Size = new System.Drawing.Size(138, 42);
            this.btn_Prikazi.TabIndex = 2;
            this.btn_Prikazi.Text = "Pretraži";
            this.btn_Prikazi.UseVisualStyleBackColor = true;
            this.btn_Prikazi.Click += new System.EventHandler(this.btn_Prikazi_Click);
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btn_Prikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmKorisnici";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btn_Prikazi;
    }
}