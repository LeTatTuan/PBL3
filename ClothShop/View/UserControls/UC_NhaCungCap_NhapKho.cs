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
    public partial class UC_NhaCungCap_NhapKho : UserControl
    {
        string MaNV;
        public UC_NhaCungCap_NhapKho(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            ReLoadNCC();
        }
        public void ReLoadNCC()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNCC();
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailNCC f = new Form_DetailNCC(null))
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

        private void buttonSuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailNCC f = new Form_DetailNCC(dataGridView1.SelectedRows[0].Cells["MaNCC"].Value.ToString()))
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaNCC = i.Cells["MaNCC"].Value.ToString();
                    if (BLL_ClothShop.Instance.CheckDelNCC(MaNCC))
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
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNCC(tbSearch.Text);
        }
    }
}
