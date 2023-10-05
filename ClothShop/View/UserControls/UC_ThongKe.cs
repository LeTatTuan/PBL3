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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            ReLoad();
        }

        public void ReLoad()
        {
            int monthNow = DateTime.Now.Month;
            lbDoanhThu.Text = BLL_ClothShop.Instance.GetDoanhSo(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now).ToString();
            lbDonHang.Text = BLL_ClothShop.Instance.GetSLHoaDon(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now).ToString();
            lbLoiNhuan.Text = BLL_ClothShop.Instance.GetLoiNhuan(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now).ToString();

            double x = BLL_ClothShop.Instance.GetLoiNhuan(new DateTime(DateTime.Now.Year, monthNow, 1).AddDays(-30), DateTime.Now.AddDays(-30)); // Lợi nhuận tháng trước
            if(x > Convert.ToDouble(lbLoiNhuan.Text))
            {
                lbSoSanh.Text = "Giảm " + (x - Convert.ToDouble(lbLoiNhuan.Text)).ToString();
            }
            else
            {
                lbSoSanh.Text = "Tăng " + (Convert.ToDouble(lbLoiNhuan.Text) - x).ToString();
            }

            // Biểu đồ doanh thu
            chartDoanhThu.Series["s2"].Points.Clear();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            List<int> s = BLL_ClothShop.Instance.GetDS12m();
            string[] monthArr = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for(int i = 11; i >= 0; i--)
            {
                if(monthNow <= i)
                {
                    chartDoanhThu.Series["s2"].Points.AddXY(monthArr[monthNow + 12 - i - 1], s[11 - i]);
                }
                else
                {
                    chartDoanhThu.Series["s2"].Points.AddXY(monthArr[monthNow - i - 1], s[11 - i]);
                }
            }

            // Biểu đồ top doanh số SP
            chartSPDS.ChartAreas["ChartArea1"].AxisY.Interval = 0;
            chartSPDS.Series["sds"].Points.Clear();
            foreach (var i in BLL_ClothShop.Instance.GetTopDoanhSoSP(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now))
            {
                chartSPDS.Series["sds"].Points.AddXY(i.TenSP, i.DoanhSo);
            }
            // Biểu đồ top số lượng SP
            chartSPSL.ChartAreas["ChartArea1"].AxisY.Interval = 0;
            chartSPSL.Series["ssl"].Points.Clear();
            foreach (var i in BLL_ClothShop.Instance.GetTopSoLuongSP(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now))
            {
                chartSPSL.Series["ssl"].Points.AddXY(i.TenSP, i.SoLuong);
            }
            // Biểu đồ top KH
            chartKH.ChartAreas["ChartArea1"].AxisY.Interval = 0;
            chartKH.Series["skh"].Points.Clear();
            foreach (var i in BLL_ClothShop.Instance.GetTopKH(new DateTime(DateTime.Now.Year, monthNow, 1), DateTime.Now))
            {
                chartKH.Series["skh"].Points.AddXY(i.TenKH, i.TongMua);
            }
        }
    }
}
