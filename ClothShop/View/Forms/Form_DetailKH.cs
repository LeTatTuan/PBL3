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
    public partial class Form_DetailKH : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string MaKH;
        public Form_DetailKH(string MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            GUI();
        }
        public void GUI()
        {
            if(MaKH != null)
            {
                lbTitle.Text = "Cập nhật khách hàng";
                tbMaKM.Text = MaKH;
                tbTenKH.Text = BLL_ClothShop.Instance.GetKHByMaKH(MaKH).TenKH;
                dtNS.Value = BLL_ClothShop.Instance.GetKHByMaKH(MaKH).NgaySinh;
                if(BLL_ClothShop.Instance.GetKHByMaKH(MaKH).GioiTinh)
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                tbDiaChi.Text = BLL_ClothShop.Instance.GetKHByMaKH(MaKH).DiaChi;
                tbSDT.Text = BLL_ClothShop.Instance.GetKHByMaKH(MaKH).SDT;
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
                    rand = "KH" + rand;
                } while (BLL_ClothShop.Instance.GetKHByMaKH(rand) != null);
                tbMaKM.Text = rand;
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(tbTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng");
            }
            else
            {
                KhachHang kh = new KhachHang
                {
                    MaKH = tbMaKM.Text,
                    TenKH = tbTenKH.Text,
                    NgaySinh = dtNS.Value,
                    GioiTinh = rbNam.Checked,
                    DiaChi = (tbDiaChi.Text != "") ? tbDiaChi.Text : "",
                    SDT = (tbSDT.Text != "") ? tbSDT.Text : ""
                };
                BLL_ClothShop.Instance.AddUpdateKH(kh);
                d();
                this.Close();
            }

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
