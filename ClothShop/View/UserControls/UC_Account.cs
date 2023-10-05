using ClothShop.BLL;
using ClothShop.DTO;
using System;
using System.Windows.Forms;

namespace ClothShop.View.UserControls
{
    public partial class UC_Account : UserControl
    {
        string MaNV;
        public UC_Account(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            GUI();
        }

        public void GUI()
        {
            tbHoTen.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV;
            tbSDT.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).SDT;
            tbDiaChi.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).DiaChi;
            if(BLL_ClothShop.Instance.GetNVByMaNV(MaNV).GioiTinh)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void buttonLuu1_Click(object sender, EventArgs e) // Cập nhập thông tin
        {
            NhanVien s = new NhanVien
            {
                MaNV = MaNV,
                TenNV = tbHoTen.Text,
                SDT = tbSDT.Text,
                DiaChi = tbDiaChi.Text,
                GioiTinh = rbNam.Checked,
                ChucVu = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).ChucVu,
                MatKhau = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).MatKhau,
            };
            BLL_ClothShop.Instance.AddUpdateNV(s);
            MessageBox.Show("Cập nhập thông tin cá nhân thành công !");
        }

        private void buttonLuu2_Click(object sender, EventArgs e)
        {
            if(tbMKCu.Text == BLL_ClothShop.Instance.GetNVByMaNV(MaNV).MatKhau)
            {
                if(tbMKMoi1.Text == tbMKMoi2.Text)
                {
                    NhanVien s = new NhanVien
                    {
                        MaNV = MaNV,
                        TenNV = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV,
                        DiaChi = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).DiaChi,
                        ChucVu = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).ChucVu,
                        SDT = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).SDT,
                        GioiTinh = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).GioiTinh,
                        MatKhau = tbMKMoi1.Text
                    };
                    BLL_ClothShop.Instance.AddUpdateNV(s);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    tbMKCu.Text = "";
                    tbMKMoi1.Text = "";
                    tbMKMoi2.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                }
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu cũ");
            }
        }
    }
}
