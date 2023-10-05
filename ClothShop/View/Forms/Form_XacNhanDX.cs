using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothShop.View.Forms
{
    public partial class Form_XacNhanDX : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public Form_XacNhanDX()
        {
            InitializeComponent();
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            d();
            this.Close();
        }

        private void butNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
