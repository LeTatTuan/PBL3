using ClothShop.BLL;
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
    public partial class Form_Dashboard : Form
    {
        string MaNV;
        public Form_Dashboard(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            lbTenNV.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV;
            lbChucVu.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).ChucVu;
            timer1.Start();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            UserControls.UC_TrangChu uc = new UserControls.UC_TrangChu();
            addControls(uc);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MovepanelSlide(Control btn)
        {
            panelSlide.Height = btn.Height;
            panelSlide.Top = btn.Top;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm");
        }
        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_TrangChu uc = new UserControls.UC_TrangChu();
            addControls(uc);
        }
        private void btnSP_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_SanPham uc = new UserControls.UC_SanPham(MaNV);
            addControls(uc);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_HoaDon uc = new UserControls.UC_HoaDon(MaNV);
            addControls(uc);
        }

        private void btnNK_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_NhapKho uc = new UserControls.UC_NhapKho(MaNV);
            addControls(uc);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_NhanVien uc = new UserControls.UC_NhanVien(MaNV);
            addControls(uc);
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_DoiTac uc = new UserControls.UC_DoiTac(MaNV);
            addControls(uc);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_ThongKe uc = new UserControls.UC_ThongKe();
            addControls(uc);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_KhuyenMai uc = new UserControls.UC_KhuyenMai(MaNV);
            addControls(uc);
        }

        private void btnCDTK_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_Account uc = new UserControls.UC_Account(MaNV);
            addControls(uc);
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            Form_XacNhanDX f = new Form_XacNhanDX();
            f.d = new Form_XacNhanDX.Mydel(CloseForm);
            f.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }
    }
}
