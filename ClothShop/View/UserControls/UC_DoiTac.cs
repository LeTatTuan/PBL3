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
    public partial class UC_DoiTac : UserControl
    {
        string MaNV;
        public UC_DoiTac(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            ReLoadKH();
            ReLoadNCC();
        }
        public void ReLoadKH()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKH();
        }
        public void ReLoadNCC()
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllNCC();
        }

        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                using(Form_DetailKH f = new Form_DetailKH(null))
                {
                    f.d = new Form_DetailKH.Mydel(ReLoadKH);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch(Exception ex)
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
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaKH = i.Cells["MaKH"].Value.ToString();
                    if(BLL_ClothShop.Instance.CheckDelKH(MaKH))
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

        private void buttonTKKH_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKH(tbSearchKH.Text);
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                using(Form_DetailNCC f = new Form_DetailNCC(null))
                {
                    f.d = new Form_DetailNCC.Mydel(ReLoadNCC);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReLoadNCC();
        }

        private void buttonSuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailNCC f = new Form_DetailNCC(dataGridView2.SelectedRows[0].Cells["MaNCC"].Value.ToString()))
                {
                    f.d = new Form_DetailNCC.Mydel(ReLoadNCC);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ReLoadNCC();
        }

        private void buttonXoaNCC_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView2.SelectedRows)
                {
                    string MaNCC = i.Cells["MaNCC"].Value.ToString();
                    if(BLL_ClothShop.Instance.CheckDelNCC(MaNCC))
                    {
                        BLL_ClothShop.Instance.DelNCC(MaNCC);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp này");
                    }
                }
            }
            ReLoadNCC();
        }

        private void buttonTKNCC_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllNCC(tbSearchNCC.Text);
        }
    }
}
