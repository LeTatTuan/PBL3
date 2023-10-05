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
    public partial class Form_DB_BanHang : Form
    {
        string MaNV;
        public Form_DB_BanHang(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            if ((lbTenNV.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).TenNV).Length > 14)
            {
                lbTenNV.Location = new Point(45, 102);
            }
            lbChucVu.Text = BLL_ClothShop.Instance.GetNVByMaNV(MaNV).ChucVu;
            timer1.Start();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            UserControls.UC_Account uc = new UserControls.UC_Account(MaNV);
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
        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm");
        }

        private void btnCDTK_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_Account uc = new UserControls.UC_Account(MaNV);
            addControls(uc);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_SanPham_Staff uc = new UserControls.UC_SanPham_Staff();
            addControls(uc);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_KH_BanHang uc = new UserControls.UC_KH_BanHang();
            addControls(uc);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            MovepanelSlide((Button)sender);
            UserControls.UC_KhuyenMai_Staff uc = new UserControls.UC_KhuyenMai_Staff();
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
