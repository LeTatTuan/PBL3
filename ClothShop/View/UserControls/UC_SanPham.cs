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
    public partial class UC_SanPham : UserControl
    {
        string MaNV;
        public UC_SanPham(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            ReLoad();
        }

        public void ReLoad()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllSP();
            dataGridView2.DataSource = null;
        }
        private void buttonTK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllSP(tbSearch.Text);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                tbMaSP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cbbSize.Items.Clear();
                cbbSize.Items.Add("All");
                cbbSize.SelectedIndex = 0;
                foreach (string i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(tbMaSP.Text))
                {
                    cbbSize.Items.Add(i);
                }

                cbbMau.Items.Clear();
                cbbMau.Items.Add("All");
                cbbMau.SelectedIndex = 0;
                foreach (string i in BLL_ClothShop.Instance.GetCBBMauByMaSP(tbMaSP.Text))
                {
                    cbbMau.Items.Add(i);
                }
                dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
            }
        }

        private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
        }

        private void cbbMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailSP f = new Form_DetailSP(null))
                {
                    f.d = new Forms.Form_DetailSP.Mydel(ReLoad);
                    f.ShowDialog();
                    // khi load xong hết tất cả đối tượng thì mới chạy code
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    using (Form_DetailSP f = new Form_DetailSP(dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString()))
                    {
                        f.d = new Form_DetailSP.Mydel(ReLoad);
                        f.ShowDialog();
                        // khi load xong hết tất cả đối tượng thì mới chạy code
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaSP = i.Cells["MaSP"].Value.ToString();
                    if (BLL_ClothShop.Instance.CheckDelSP(MaSP))
                    {
                        BLL_ClothShop.Instance.DelSP(MaSP);
                    }
                    else
                        MessageBox.Show("Không thể xóa sản phẩm này");
                }
                ReLoad();
            }
        }
    }
}