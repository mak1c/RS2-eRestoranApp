using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Proizvodi
{
    public partial class ProizvodItem : Bunifu.UI.WinForms.BunifuUserControl
    {
        public ProizvodItem()
        {
            InitializeComponent();
        }
        public Image ItemImage
        {
            get
            {
                return pictureBox2.Image;
            }
            set
            {
                pictureBox2.Image = value;
            }
        }
        public string ItemLabel
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }

    }
   
}