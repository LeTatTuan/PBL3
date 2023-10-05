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

namespace ClothShop.View.UserControls
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
            Reload();
            chartTron.Titles.Add("");
        }

        public void Reload()
        {
            lbSoLuong.Text = BLL_ClothShop.Instance.GetSLSPBan(DateTime.Now.AddDays(-30), DateTime.Now).ToString();
            lbDoanhSo.Text = BLL_ClothShop.Instance.GetDoanhSo(DateTime.Now.AddDays(-30), DateTime.Now).ToString();
            lbLoiNhuan.Text = BLL_ClothShop.Instance.GetLoiNhuan(DateTime.Now.AddDays(-30), DateTime.Now).ToString();
            chartCot.Series["s2"].Points.Clear();
            chartCot.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            int monthNow = DateTime.Now.Month;
            List<int> s = BLL_ClothShop.Instance.GetDS12m();
            string[] monthArr = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for (int i = 11; i >= 0; i--)
            {
                if (monthNow <= i)
                {
                    chartCot.Series["s2"].Points.AddXY(monthArr[monthNow + 12 - i - 1], s[11 - i]);
                }
                else
                {
                    chartCot.Series["s2"].Points.AddXY(monthArr[monthNow - i - 1], s[11 - i]);
                }
            }
            chartTron.Series["s1"].Points.Clear();
            double[] p = BLL_ClothShop.Instance.GetDSTheoNhomSP();
            foreach(var i in BLL_ClothShop.Instance.GetAllNhomSP())
            {
                chartTron.Series["s1"].Points.AddXY(i.Text, p[i.Value - 1]);
            }
        }
    }
}
