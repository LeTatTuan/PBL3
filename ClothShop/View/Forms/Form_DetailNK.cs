using ClothShop.BLL;
using ClothShop.DTO;
using System;
using System.Windows.Forms;

namespace ClothShop.View.Forms
{
    public partial class Form_DetailNK : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        string MaNV, MaNK;
        string MaNguoiTao = null, MaNCC = null, MaSP = null;
        public Form_DetailNK(string maNK, string maNV)
        {
            InitializeComponent();
            MaNK = maNK;
            MaNV = maNV;
            GUI();
            BLL_ClothShop.Instance.CopyNK(MaNK);
            ReLoad();
        }

        public void ReLoad()
        {
            Random rd = new Random();
            string rand;
            do
            {
                rand = "";
                rand = rd.Next(0, 99999999).ToString();
                for (int i = 0; i < (8 - rand.Length); i++)
                    rand = "0" + rand;
                rand = "CN" + rand;
            }
            while (BLL_ClothShop.Instance.GetCTNKByMaCTNK(rand) != null);
            lbMaCTNK.Text = rand;
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetCTNKByMaNK("NK00000000");
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllSPView();
            dataGridView2.Rows[0].Selected = true;
            cbbSearchNCC.SelectedIndex = 0;
            MaSP = dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString();
            lbTenSP.Text = BLL_ClothShop.Instance.GetSPByMaSP(MaSP).TenSP;
            cbbSize.Items.Clear();
            foreach (var i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(MaSP))
            {
                cbbSize.Items.Add(i.ToString());
            }
            cbbSize.SelectedIndex = 0;
            cbbMauSac.Items.Clear();
            foreach (var i in BLL_ClothShop.Instance.GetCBBMauByMaSP(MaSP))
            {
                cbbMauSac.Items.Add(i.ToString());
            }
            cbbMauSac.SelectedIndex = 0;
            tbGiaNhap.Text = "";
            tbSoLuong.Text = "";
            lbTongSL.Text = BLL_ClothShop.Instance.GetSoLuongNK("NK00000000").ToString();
            lbTong.Text = BLL_ClothShop.Instance.GetTongNK("NK00000000").ToString();
        }
        public void GUI()
        {
            if (MaNK != null)
            {
                lbMaNK.Text = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).MaNK;
                MaNCC = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).MaNCC;
                lbTenNCC.Text = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).NhaCungCap.TenNCC;
                lbNgayTao.Text = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).NgayTao.ToString();
                MaNguoiTao = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).ID_NguoiTao;
                lbTenNV.Text = BLL_ClothShop.Instance.GetNKByMaNK(MaNK).NguoiTao.TenNV;
            }
            else
            {
                Random rd = new Random();
                string rand;
                do
                {
                    rand = "";
                    rand = rd.Next(0, 99999999).ToString();
                    for (int i = 0; i < (8 - rand.Length); i++)
                        rand = "0" + rand;
                    rand = "NK" + rand;
                }
                while (BLL_ClothShop.Instance.GetNKByMaNK(rand) != null);
                lbMaNK.Text = rand;
                lbNgayTao.Text = DateTime.Now.ToString();
                MaNguoiTao = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).MaNV;
                lbTenNV.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV;
            }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaCTNK = dataGridView1.SelectedRows[0].Cells["MaCTNK"].Value.ToString();
                if (MaCTNK != null)
                {
                    MaSP = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).MaCTSP).MaSP;
                    lbTenSP.Text = BLL_ClothShop.Instance.GetSPByMaSP(MaSP).TenSP;
                    lbMaCTNK.Text = BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).MaCTNK;
                    cbbSize.Items.Clear();
                    foreach (var i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(MaSP))
                    {
                        cbbSize.Items.Add(i.ToString());
                    }
                    cbbSize.SelectedItem = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).MaCTSP).Size;
                    cbbMauSac.Items.Clear();
                    foreach (var i in BLL_ClothShop.Instance.GetCBBMauByMaSP(MaSP))
                    {
                        cbbMauSac.Items.Add(i.ToString());
                    }
                    cbbMauSac.SelectedItem = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).MaCTSP).MauSac;
                    tbGiaNhap.Text = BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).GiaNhap.ToString();
                    tbSoLuong.Text = BLL_ClothShop.Instance.GetCTNKByMaCTNK(MaCTNK).SoLuong.ToString();
                }
            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                MaSP = dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString();
                lbTenSP.Text = BLL_ClothShop.Instance.GetSPByMaSP(MaSP).TenSP;
                cbbSize.Items.Clear();
                foreach (var i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(MaSP))
                {
                    cbbSize.Items.Add(i.ToString());
                }
                cbbSize.SelectedIndex = 0;
                cbbMauSac.Items.Clear();
                foreach (var i in BLL_ClothShop.Instance.GetCBBMauByMaSP(MaSP))
                {
                    cbbMauSac.Items.Add(i.ToString());
                }
                cbbMauSac.SelectedIndex = 0;
            }
        }
      
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaCTNK = i.Cells["MaCTNK"].Value.ToString();
                    BLL_ClothShop.Instance.DelCTNK(MaCTNK);
                }
                ReLoad();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa !");
            }
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {
            if (BLL_ClothShop.Instance.CheckNum(tbGiaNhap.Text) == -1) MessageBox.Show("Giá nhập không thể trống");
            else if (BLL_ClothShop.Instance.CheckNum(tbGiaNhap.Text) == 0) MessageBox.Show("Giá nhập không thể bằng không");
            else if (BLL_ClothShop.Instance.CheckNum(tbGiaNhap.Text) == 1) MessageBox.Show("Giá nhập không thể chứa các ký tự khác ngoài số");
            else if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == -1) MessageBox.Show("Số lượng không thể trống");
            else if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == 0) MessageBox.Show("Số lượng không thể bằng không");
            else if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == 1) MessageBox.Show("Số lượng không thể chứa các ký tự khác ngoài số");
            else if ((tbGiaNhap.Text != null || tbGiaNhap.Text != "") && (tbSoLuong.Text != null || tbSoLuong.Text != ""))
            {
                string MaCTSP = BLL_ClothShop.Instance.GetCTSPByMaSP(MaSP, cbbSize.SelectedItem.ToString(), cbbMauSac.SelectedItem.ToString())[0].MaCTSP;
                CTNhapKho s = null;
                foreach (var i in BLL_ClothShop.Instance.GetCTNKByMaNK("NK00000000"))
                {
                    if (BLL_ClothShop.Instance.GetCTNKByMaCTNK(i.MaCTNK).MaCTSP == MaCTSP)
                    {
                        s = new CTNhapKho
                        {
                            MaCTNK = i.MaCTNK,
                            MaNK = "NK00000000",
                            MaCTSP = BLL_ClothShop.Instance.GetCTSPByMaSP(MaSP, cbbSize.SelectedItem.ToString(), cbbMauSac.SelectedItem.ToString())[0].MaCTSP,
                            GiaNhap = Convert.ToInt32(tbGiaNhap.Text),
                            SoLuong = (i.MaCTNK != "AO" + lbMaCTNK.Text.Substring(2)) ? BLL_ClothShop.Instance.GetCTNKByMaCTNK(i.MaCTNK).SoLuong + Convert.ToInt32(tbSoLuong.Text) : Convert.ToInt32(tbSoLuong.Text),
                        };
                    }
                }
                if (s == null)
                    s = new CTNhapKho
                    {
                        MaCTNK = "AO" + lbMaCTNK.Text.Substring(2),
                        MaNK = "NK00000000",
                        MaCTSP = MaCTSP,
                        GiaNhap = Convert.ToInt32(tbGiaNhap.Text),
                        SoLuong = Convert.ToInt32(tbSoLuong.Text)
                    };
                BLL_ClothShop.Instance.AddUpdateCTNK(s);
                ReLoad();
            }
        }
        private void buttonLuu2_Click(object sender, EventArgs e)
        {
            if (MaNCC == null)
            {
                MessageBox.Show("Không thể để trống nhà cung cấp");
                return;
            }
            NhapKho s = new NhapKho
            {
                MaNK = lbMaNK.Text,
                MaNCC = (MaNCC != "") ? MaNCC : "NCC0000000",
                NgayTao = Convert.ToDateTime(lbNgayTao.Text),
                ID_NguoiTao = MaNguoiTao,
                NgaySua = DateTime.Now,
                ID_NguoiSua = MaNV
            };
            BLL_ClothShop.Instance.AddUpdateNK(s);
            BLL_ClothShop.Instance.PasteNK(lbMaNK.Text);
            d();
            this.Close();
        }

        private void btAddSP_Click(object sender, EventArgs e)
        {
            using (Form_DetailSP f = new Form_DetailSP(null))
            {
                f.d = new Form_DetailSP.Mydel(ReLoad);
                f.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btSearchSP_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllSPView(tbSearchSP.Text);
        }

        private void btSearchNCC_Click(object sender, EventArgs e)
        {

            if (cbbSearchNCC.SelectedIndex == 0)
            {
                if (BLL_ClothShop.Instance.GetNCCBySDT(tbSearchNCC.Text) == null)
                {
                    MessageBox.Show("Không tồn tại nhà cung cấp có SDT này!");
                }
                else
                {
                    MaNCC = BLL_ClothShop.Instance.GetNCCBySDT(tbSearchNCC.Text);
                    lbTenNCC.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).TenNCC;
                }
            }
            else
            {
                if (BLL_ClothShop.Instance.GetNCCByMaNCC(tbSearchNCC.Text) == null)
                {
                    MessageBox.Show("Không tồn tại nhà cung cấp có mã này!");
                }
                else
                {
                    MaNCC = tbSearchNCC.Text;
                    lbTenNCC.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).TenNCC;
                }
            }
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                BLL_ClothShop.Instance.DelCTNK(i.Cells["MaCTNK"].Value.ToString());
            }
            this.Close();
        }
    }
}
