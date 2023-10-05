using ClothShop.BLL;
using ClothShop.DTO;
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
    public partial class Form_DetailHD : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        string MaHD, MaNV;
        public Form_DetailHD(string MaHD, string MaNV)
        {
            InitializeComponent();
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            GUI();
            BLL_ClothShop.Instance.CopyHD(MaHD);
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
                rand = "CH" + rand;
            }
            while (BLL_ClothShop.Instance.GetCTHDByMaCTHD(rand) != null);
            tbMaCTHD.Text = rand;
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetCTHDByMaHD("HD00000000");  // lay ra CTHD moi copy sang MaHD mau HD00000000
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllSPView();
            dataGridView2.Rows[0].Selected = true;
            cbbSearchKH.SelectedIndex = 0;
            lbMaSP.Text = dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString();
            tbSoLuong.Text = "0";
            lbSoLuong.Text = BLL_ClothShop.Instance.GetSoLuongHD("HD00000000").ToString();
            lbTong.Text = BLL_ClothShop.Instance.GetTongHD("HD00000000").ToString();
            lbThanhTien.Text = (Convert.ToInt32(lbTong.Text) * (1 - Convert.ToDouble(lbGiaTriKM.Text) / 100)).ToString();
        }
        public void GUI()
        {
            if (MaHD != null)
            {
                lbTitle.Text = "Cập nhật hóa đơn";
                lbMaHD.Text = MaHD;
                lbMaNV.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).ID_NguoiTao;
                lbTenNV.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).NguoiTao.TenNV;
                lbNgayTao.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).NgayTao.ToString();
                lbTenKH.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).KhachHang.TenKH;
                lbMaKH.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).MaKH;
                tbMaKM.Text = BLL_ClothShop.Instance.GetHDByMaHD(MaHD).MaKM;
                lbTenKM.Text = (tbMaKM.Text != "") ? BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).TenKM : "";
                lbGiaTriKM.Text = (tbMaKM.Text != "") ? (BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).GiaTri * 100).ToString() : "0";
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
                    rand = "HD" + rand;
                }
                while (BLL_ClothShop.Instance.GetHDByMaHD(rand) != null);
                lbMaHD.Text = rand;
                lbMaKH.Text = "KH00000000";
                lbTenKH.Text = BLL_ClothShop.Instance.GetKHByMaKH(lbMaKH.Text).TenKH;
                lbMaNV.Text = MaNV;
                lbTenNV.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV;
                lbNgayTao.Text = DateTime.Now.ToString();
                tbMaKM.Text = "";
                lbTenKM.Text = "";
                lbGiaTriKM.Text = "0";
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaCTHD = dataGridView1.SelectedRows[0].Cells["MaCTHD"].Value.ToString();
                tbMaCTHD.Text = MaCTHD;
                lbMaSP.Text = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTHDByMaCTHD(MaCTHD).MaCTSP).MaSP;
                cbbMauSac.Items.Clear();
                foreach(var i in BLL_ClothShop.Instance.GetCBBMauByMaSP(lbMaSP.Text))
                {
                    cbbMauSac.Items.Add(i.ToString());
                }
                cbbMauSac.SelectedItem = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTHDByMaCTHD(MaCTHD).MaCTSP).MauSac;
                cbbSize.Items.Clear();
                foreach (var i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(lbMaSP.Text))
                {
                    cbbSize.Items.Add(i.ToString());
                }
                cbbSize.SelectedItem = BLL_ClothShop.Instance.GetCTSPByMaCTSP(BLL_ClothShop.Instance.GetCTHDByMaCTHD(MaCTHD).MaCTSP).Size;
                tbSoLuong.Text = BLL_ClothShop.Instance.GetCTHDByMaCTHD(MaCTHD).SoLuong.ToString();
            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count == 1)
            {
                string MaSP = dataGridView2.SelectedRows[0].Cells["MaSP"].Value.ToString();
                lbMaSP.Text = MaSP;
                cbbMauSac.Items.Clear();
                foreach(var i in BLL_ClothShop.Instance.GetCBBMauByMaSP(MaSP))
                {
                    cbbMauSac.Items.Add(i.ToString());
                }
                cbbMauSac.SelectedItem = 0;
                cbbSize.Items.Clear();
                foreach (var i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(MaSP))
                {
                    cbbSize.Items.Add(i.ToString());
                }
                cbbSize.SelectedItem = 0;
            }
        }
        private void btSearchKH_Click(object sender, EventArgs e)
        {
           if(cbbSearchKH.SelectedIndex == 0)
           {
                if(BLL_ClothShop.Instance.GetKHBySDT(tbSearchKH.Text) == null)
                {
                    MessageBox.Show("Không tồn tại khách hàng có SĐT này!");
                }
                else
                {
                    lbMaKH.Text = BLL_ClothShop.Instance.GetKHBySDT(tbSearchKH.Text);
                    lbTenKH.Text = BLL_ClothShop.Instance.GetKHByMaKH(lbMaKH.Text).TenKH;
                }
           }
            else
            {
                if (BLL_ClothShop.Instance.GetKHByMaKH(tbSearchKH.Text) == null)
                {
                    MessageBox.Show("Không tồn tại khách hàng có mã khách hàng này!");
                }
                else
                {
                    lbMaKH.Text = BLL_ClothShop.Instance.GetKHByMaKH(tbSearchKH.Text).MaKH;
                    lbTenKH.Text = BLL_ClothShop.Instance.GetKHByMaKH(lbMaKH.Text).TenKH;
                }
            }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            string txt = null;
            if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == -1) txt = "Số lượng không thể rỗng";
            else if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == 0) txt = "Số lượng không thể bằng không";
            else if (BLL_ClothShop.Instance.CheckNum(tbSoLuong.Text) == 1) txt = "Số lượng không thể chứa các ký tự khác ngoài số";
            if (txt == null)
            {
                foreach (char i in tbSoLuong.Text)
                {
                    if ((i < '0') || (i > '9'))
                    {
                        MessageBox.Show("Số lượng không hợp lệ");
                        tbSoLuong.Text = "";
                        return;
                    }
                }
                string MaCTSP = BLL_ClothShop.Instance.GetCTSPByMaSP(lbMaSP.Text, cbbSize.SelectedItem.ToString(), cbbMauSac.SelectedItem.ToString())[0].MaCTSP;
                CTHoaDon s = null;
                foreach (var i in BLL_ClothShop.Instance.GetCTHDByMaHD("HD00000000"))
                {
                    if (BLL_ClothShop.Instance.GetCTHDByMaCTHD(i.MaCTHD).MaCTSP == MaCTSP)
                    {
                        s = new CTHoaDon
                        {
                            MaCTHD = i.MaCTHD,
                            MaHD = "HD00000000",
                            MaCTSP = BLL_ClothShop.Instance.GetCTSPByMaSP(lbMaSP.Text, cbbSize.SelectedItem.ToString(), cbbMauSac.SelectedItem.ToString())[0].MaCTSP,
                            GiaBan = BLL_ClothShop.Instance.GetSPByMaSP(lbMaSP.Text).GiaBan,
                            KhuyenMai = BLL_ClothShop.Instance.GetSPByMaSP(lbMaSP.Text).KhuyenMai,
                            SoLuong = (i.MaCTHD != "AO" + tbMaCTHD.Text.Substring(2)) ? BLL_ClothShop.Instance.GetCTHDByMaCTHD(i.MaCTHD).SoLuong + Convert.ToInt32(tbSoLuong.Text) : Convert.ToInt32(tbSoLuong.Text),
                        };
                    }
                }
                if (s == null)
                    s = new CTHoaDon
                    {
                        MaCTHD = "AO" + tbMaCTHD.Text.Substring(2),
                        MaHD = "HD00000000",
                        MaCTSP = MaCTSP,
                        GiaBan = BLL_ClothShop.Instance.GetSPByMaSP(lbMaSP.Text).GiaBan,
                        KhuyenMai = BLL_ClothShop.Instance.GetSPByMaSP(lbMaSP.Text).KhuyenMai,
                        SoLuong = Convert.ToInt32(tbSoLuong.Text),
                    };
                if (BLL_ClothShop.Instance.GetCTSPByMaCTSP(s.MaCTSP).SoLuong < s.SoLuong)
                    MessageBox.Show("Không đủ số lượng. Số lượng còn lại trong kho: " + BLL_ClothShop.Instance.GetCTSPByMaCTSP(s.MaCTSP).SoLuong);
                else
                    BLL_ClothShop.Instance.AddUpdateCTHD(s);
                ReLoad();
            }
            else
            {
                try
                {
                    using (Form_Message f = new Form_Message(txt))
                    {
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void DelCTHD()
        {
            foreach(DataGridViewRow i in dataGridView1.SelectedRows)
            {
                BLL_ClothShop.Instance.DelCTHD(i.Cells["MaCTHD"].Value.ToString());
            }
            ReLoad();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaCTHD = i.Cells["MaCTHD"].Value.ToString();
                    BLL_ClothShop.Instance.DelCTHD(MaCTHD);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa !");
            }
            ReLoad();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon s = new HoaDon
                {
                    MaHD = lbMaHD.Text,
                    MaKH = (lbMaKH.Text != "") ? lbMaKH.Text : "KH00000000",
                    MaKM = (tbMaKM.Text != "") ? tbMaKM.Text : null,
                    GiaTriKM = (tbMaKM.Text != "") ? Convert.ToDouble(lbGiaTriKM.Text) / 100 : 0,
                    ID_NguoiTao = lbMaNV.Text,
                    NgayTao = Convert.ToDateTime(lbNgayTao.Text),
                    ID_NguoiSua = MaNV,
                    NgaySua = DateTime.Now,
                };
                BLL_ClothShop.Instance.AddUpdateHD(s);
                BLL_ClothShop.Instance.PasteHD(lbMaHD.Text);
                d();
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCheckKM_Click(object sender, EventArgs e)
        {
            if(BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text) == null)
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ!");
                tbMaKM.Text = "";
                lbTenKM.Text = "";
                lbGiaTriKM.Text = "";
            }
            else if(DateTime.Now < BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).NgayApDung
                                || BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).NgayApDung.AddDays(BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).HanSuDung) < DateTime.Now)
            {
                MessageBox.Show("Mã đã hết hạn sử dụng");
                tbMaKM.Text = "";
                lbTenKM.Text = "";
                lbGiaTriKM.Text = "0";
            }
            else
            {
                lbTenKM.Text = BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).TenKM;
                lbGiaTriKM.Text = (BLL_ClothShop.Instance.GetKMByMaKM(tbMaKM.Text).GiaTri*100).ToString();
            }
            ReLoad();
        }

        private void btSearchSP_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetAllSPView(tbSearchSP.Text);
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow i in dataGridView1.Rows)
            {
                BLL_ClothShop.Instance.DelCTHD(i.Cells["MaCTHD"].Value.ToString());
            }
            this.Close();
        }
    }
}
