using ClothShop.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothShop.View.UserControls
{
    public partial class UC_KhuyenMai_Staff : UserControl
    {
        public UC_KhuyenMai_Staff()
        {
            InitializeComponent();
            ReLoad();
        }
        public void ReLoad()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKM();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKM(tbSearch.Text);
        }
    }
}
