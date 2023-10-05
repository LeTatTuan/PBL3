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
    public partial class UC_KH_ThuNgan : UserControl
    {
        string MaNV;
        public UC_KH_ThuNgan(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            ReLoadKH();
        }
        public void ReLoadKH()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKH();
        }

        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailKH f = new Form_DetailKH(null))
                {
                    f.d = new Form_DetailKH.Mydel(ReLoadKH);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReLoadKH();
        }

        private void buttonSuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailKH f = new Form_DetailKH(dataGridView1.SelectedRows[0].Cells["MaKh"].Value.ToString()))
                {
                    f.d = new Form_DetailKH.Mydel(ReLoadKH);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReLoadKH();
        }

        private void buttonXoaKH_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaKH = i.Cells["MaKH"].Value.ToString();
                    if (BLL_ClothShop.Instance.CheckDelKH(MaKH))
                    {
                        BLL_ClothShop.Instance.DelKH(MaKH);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng này!!!");
                    }
                }
            }
            ReLoadKH();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKH(tbSearch.Text);
        }
    }
}
