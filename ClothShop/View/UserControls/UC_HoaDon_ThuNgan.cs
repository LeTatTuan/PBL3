using ClothShop.BLL;
using ClothShop.View.Forms;
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
    public partial class UC_HoaDon_ThuNgan : UserControl
    {
        string MaNV;
        public UC_HoaDon_ThuNgan(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            Reload();
        }
        public void Reload()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllHD();
            dataGridView2.DataSource = null;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using(Form_DetailHD f = new Form_DetailHD(null, MaNV))
                {
                    f.d = new Form_DetailHD.Mydel(Reload);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    using (Form_DetailHD f = new Form_DetailHD(dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString(), MaNV))
                    {
                        f.d = new Form_DetailHD.Mydel(Reload);
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonTK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllHD(tbSearch.Text);
            dataGridView2.DataSource = null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                tbCTHD.Text = dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString();
                dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTHDByMaHD(dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString());
            }
        }
    }
}
