using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothShop.BLL;
using ClothShop.DTO;
namespace ClothShop.View.Forms
{
    public partial class Form_DetailNV : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        string MaNV;
        public Form_DetailNV(string nv)
        {
            InitializeComponent();
            MaNV = nv;
            GUI();
        }
        public void GUI()
        {
            if(MaNV != null)
            {
                lbTitle.Text = "Cập nhật nhân viên";
                tbMaNV.Text = MaNV;
                tbTenNV.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV;
                if (BLL_ClothShop.Instance.GetNVByMaNV(MaNV).GioiTinh) rbNam.Checked = true;
                else rbNu.Checked = true;
                cbbChucVu.SelectedItem = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).ChucVu;
                tbDiaChi.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).DiaChi;
                tbSDT.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).SDT;
            } 
            else
            {
                string rand;
                do
                {
                    rand = "NV" + BLL_ClothShop.Instance.GetRandom();
                }
                while (BLL_ClothShop.Instance.GetNVByMaNV(rand) != null);   
                tbMaNV.Text = rand;
                cbbChucVu.SelectedIndex = 0;
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if (tbTenNV.Text == null || tbTenNV.Text == "") MessageBox.Show("Tên nhân viên không được để trống");
            else if (tbSDT.Text == null || tbSDT.Text == "" || tbSDT.Text.Length != 10) MessageBox.Show("Số điện thoại trống hoặc không hợp lệ");
            else
            {
                NhanVien s = new NhanVien
                {
                    MaNV = tbMaNV.Text,
                    TenNV = tbTenNV.Text,
                    DiaChi = (tbDiaChi.Text != "") ? tbDiaChi.Text : "",
                    SDT = tbSDT.Text,
                    GioiTinh = rbNam.Checked,
                    ChucVu = cbbChucVu.SelectedItem.ToString(),
                    MatKhau = (BLL_ClothShop.Instance.GetNVByMaNV(MaNV) == null) ? "123" : BLL_ClothShop.Instance.GetNVByMaNV(MaNV).MatKhau,
                };
                BLL_ClothShop.Instance.AddUpdateNV(s);
                d();
                this.Close();
            }    
        }
    }
}
