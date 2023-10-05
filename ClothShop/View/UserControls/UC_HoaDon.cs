using ClothShop.BLL;
using ClothShop.View.Forms;
using System;
using System.Windows.Forms;

namespace ClothShop.View.UserControls
{
    public partial class UC_HoaDon : UserControl
    {
        private string MaNV;
        public UC_HoaDon(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            ReLoad();
        }
        public void ReLoad()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllHD();
            dataGridView2.DataSource = null;
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllHD(tbSearch.Text);
            dataGridView2.DataSource = null;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailHD f = new Form_DetailHD(null, MaNV))
                {
                    f.d = new Form_DetailHD.Mydel(ReLoad);
                    f.ShowDialog();
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
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    using (Form_DetailHD f = new Form_DetailHD(dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString(), MaNV))
                    {
                        f.d = new Form_DetailHD.Mydel(ReLoad);
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaHD = i.Cells["MaHD"].Value.ToString();
                    BLL_ClothShop.Instance.DelHD(MaHD);
                }
                ReLoad();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                tbCTHD.Text = dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString();
                dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTHDByMaHD(tbCTHD.Text);
            }
        }
    }
}
