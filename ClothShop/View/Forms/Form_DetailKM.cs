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
    public partial class Form_DetailKM : Form
    {
       
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string MaKM;
        public Form_DetailKM(string MaKM)
        {
            InitializeComponent();
            this.MaKM = MaKM;
            GUI();
        }

        public void GUI()
        {
            if (MaKM != null)
            {
                lbTitle.Text = "Cập nhật mã khuyến mãi";
                tbMaKM.Text = MaKM;
                tbTenKM.Text = BLL_ClothShop.Instance.GetKMByMaKM(MaKM).TenKM;
                tbGiaTri.Text = (BLL_ClothShop.Instance.GetKMByMaKM(MaKM).GiaTri*100).ToString();
                dateTimePicker1.Value = BLL_ClothShop.Instance.GetKMByMaKM(MaKM).NgayApDung;
                tbMoTa.Text = BLL_ClothShop.Instance.GetKMByMaKM(MaKM).MoTa;
                tbHSD.Text = BLL_ClothShop.Instance.GetKMByMaKM(MaKM).HanSuDung.ToString();
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
                    {
                        rand = "0" + rand;
                    }
                    rand = "KM" + rand;
                } while (BLL_ClothShop.Instance.GetKMByMaKM(rand) != null);
                tbMaKM.Text = rand;
            }
        }
        private void butLuu_Click(object sender, EventArgs e)
        {
            if(tbGiaTri.Text == "" || Convert.ToDouble(tbGiaTri.Text) <= 0)
            {
                MessageBox.Show("Giá trị khuyến mãi không hợp lệ!!!!");
                return;
            }
            if(tbTenKM.Text == "" || tbTenKM.Text == null)
            {
                MessageBox.Show("Vui lòng nhập tên mã khuyến mãi !");
                return;
            }
            KhuyenMai km = new KhuyenMai
            {
                MaKM = tbMaKM.Text,
                TenKM = tbTenKM.Text,
                NgayApDung = dateTimePicker1.Value,
                HanSuDung = (tbHSD.Text != "") ? Convert.ToInt32(tbHSD.Text) : 0,
                MoTa = (tbMoTa.Text != "") ? tbMoTa.Text : "",
                GiaTri = (tbGiaTri.Text != "") ? Convert.ToDouble(tbGiaTri.Text) / 100 : 0 
            };
            BLL_ClothShop.Instance.AddUpdateKM(km);
            d();
            this.Close();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
