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
    public partial class Form_Message : Form
    {
        public Form_Message(string msg)
        {
            InitializeComponent();
            labelMsg.Text = msg;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
