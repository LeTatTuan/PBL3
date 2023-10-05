using System;
using System.Windows.Forms;
using ClothShop.View.Forms;
using ClothShop.BLL;
namespace ClothShop.View.UserControls
{
    public partial class UC_NhanVien : UserControl
    {
        string MaNV;
        public UC_NhanVien(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            ReLoad();
        }
        public void ReLoad()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNV();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNV(tbSearch.Text);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            using (Form_DetailNV f = new Form_DetailNV(null))
            {
                f.d = new Form_DetailNV.MyDel(ReLoad);
                f.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                using(Form_DetailNV f = new Form_DetailNV(dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString()))
                {
                    f.d = new Form_DetailNV.MyDel(ReLoad);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaNV = i.Cells["MaNV"].Value.ToString();
                    if (BLL_ClothShop.Instance.CheckDelNV(MaNV))
                    {
                        BLL_ClothShop.Instance.DelNV(MaNV);
                    }
                    else
                        MessageBox.Show("Không thể xóa nhân viên này");
                }
                ReLoad();
            }
        }

        private void buttonRSMK_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string MaNV = dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString();
                BLL_ClothShop.Instance.ResetMKNV(MaNV);
                MessageBox.Show("Reset mật khẩu cho tài khoản nhân viên thành công!");
            }
        }
    }
}
