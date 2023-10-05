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
    public partial class Form_DetailNCC : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string MaNCC;
        public Form_DetailNCC(string MaNCC)
        {
            InitializeComponent();
            this.MaNCC = MaNCC;
            GUI();
        }
        public void GUI()
        {
            if(MaNCC != null)
            {
                lbTitle.Text = "Cập nhật nhà cung cấp";
                tbMaNCC.Text = MaNCC;
                tbTenNCC.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).TenNCC;
                tbDiaChi.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).DiaChi;
                tbSDT.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).SDT;
                tbEmail.Text = BLL_ClothShop.Instance.GetNCCByMaNCC(MaNCC).Mail;
            }
            else
            {
                Random rd = new Random();
                string rand;
                do
                {
                    rand = "";
                    rand = rd.Next(0, 9999999).ToString();
                    for(int i = 0; i < (7 - rand.Length); i++)
                        rand = "0" + rand;
                    rand = "NCC" + rand;
                } while (BLL_ClothShop.Instance.GetNCCByMaNCC(rand) != null);
                tbMaNCC.Text = rand;
            }
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if(tbTenNCC.Text != "" && tbDiaChi.Text != "" && tbSDT.Text != "" && tbEmail.Text != "")
            {
                NhaCungCap ncc = new NhaCungCap
                {
                    MaNCC = tbMaNCC.Text,
                    TenNCC = tbTenNCC.Text,
                    DiaChi = tbDiaChi.Text,
                    SDT = tbSDT.Text,
                    Mail = tbEmail.Text
                };
                BLL_ClothShop.Instance.AddUpdateNCC(ncc);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin cho nhà cung cấp mới");
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
