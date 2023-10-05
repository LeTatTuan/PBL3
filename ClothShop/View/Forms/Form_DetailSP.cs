using ClothShop.BLL;
using ClothShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClothShop.View.Forms
{
    public partial class Form_DetailSP : Form
    {
        List<string> size = new List<string>();
        List<string> mausac = new List<string>();

        public delegate void Mydel();
        public Mydel d { get; set; }
        string MaSP;
        public Form_DetailSP(string MaSP)
        {
            this.MaSP = MaSP;
            InitializeComponent();
            ReloadCBB();
            BLL_ClothShop.Instance.CopySP(MaSP);
            GUI();
        }

        public void ReloadCBB()
        {
            cbbNhomSP.Items.Clear();
            cbbNhomSP.Items.AddRange(BLL_ClothShop.Instance.GetAllNhomSP().ToArray());
            cbbNhomSP.SelectedIndex = 0;
        }

        public void GUI()
        {
            if (MaSP != null)
            {
                lbTitle.Text = "Cập nhật sản phẩm";
                tbMaSP.Text = MaSP;
                tbMaSP.Enabled = false;
                tbTenSP.Text = BLL_ClothShop.Instance.GetSPByMaSP(MaSP).TenSP;
                foreach (CBBNhomSP i in cbbNhomSP.Items)
                {
                    if (i.Value == BLL_ClothShop.Instance.GetSPByMaSP(MaSP).ID_NhomSP)
                    {
                        cbbNhomSP.SelectedItem = i;
                    }
                }
                tbGiaBan.Text = BLL_ClothShop.Instance.GetSPByMaSP(MaSP).GiaBan.ToString();
                tbKhuyenMai.Text = (BLL_ClothShop.Instance.GetSPByMaSP(MaSP).KhuyenMai*100).ToString();
                size = BLL_ClothShop.Instance.GetCBBSizeByMaSP(MaSP);
                mausac = BLL_ClothShop.Instance.GetCBBMauByMaSP(MaSP);
                dataGridView1.DataSource = size.Select(p => new { Size = p }).ToList();
                dataGridView2.DataSource = mausac.Select(p => new { Mau = p }).ToList();
            }
            else
            {
                Random rd = new Random();
                string r;
                do
                {
                    r = "";
                    r = rd.Next(0, 99999999).ToString();
                    for (int i = 0; i < (8 - r.Length); i++)
                        r = "0" + r;
                    r = "SP" + r;
                } while (BLL_ClothShop.Instance.GetSPByMaSP(r) != null);
                tbMaSP.Text = r;
                tbMaSP.Enabled = false;
                size.Add("Freesize");
                mausac.Add("Mặc định");
                BLL_ClothShop.Instance.AddCTSP("SP00000000", "Freesize", "Mặc định");
                dataGridView1.DataSource = size.Select(p => new { Size = p }).ToList();
                dataGridView2.DataSource = mausac.Select(p => new { Mau = p }).ToList();
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                tbSize.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbSizeIndex.Text = dataGridView1.SelectedRows[0].Index.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                tbMau.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                lbMauIndex.Text = dataGridView2.SelectedRows[0].Index.ToString();
            }
        }
        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_AddNhomSP f = new Form_AddNhomSP())
                {
                    f.d = new Form_AddNhomSP.Mydel(ReloadCBB);
                    f.ShowDialog();
                    // khi load xong hết tất cả đối tượng thì mới chạy code
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddSize_Click(object sender, EventArgs e)
        {
            lbSizeIndex.Text = "";
            tbSize.Text = "";
        }

        private void btAddMau_Click(object sender, EventArgs e)
        {
            lbMauIndex.Text = "";
            tbMau.Text = "";
        }

        private void btSaveSize_Click(object sender, EventArgs e)
        {
            if(lbSizeIndex.Text == "")
            {
                    size.Add(tbSize.Text);
                    foreach (string i in mausac)
                    {
                        BLL_ClothShop.Instance.AddCTSP("SP00000000", tbSize.Text, i);
                    }
            }
            else
            {
            int index = Convert.ToInt32(lbSizeIndex.Text);
            foreach (var i in BLL_ClothShop.Instance.GetCTSPByMaSP("SP00000000", size[index], "All"))
            {
                CTSanPham s = new CTSanPham
                {
                    MaCTSP = i.MaCTSP,
                    MauSac = i.MauSac,
                    Size = tbSize.Text,
                    SoLuong = i.SoLuong,
                    MaSP = BLL_ClothShop.Instance.GetCTSPByMaCTSP(i.MaCTSP).MaSP,
                };
                BLL_ClothShop.Instance.AddUpdateCTSP(s);
            }
            size[index] = tbSize.Text;
            }
            dataGridView1.DataSource = size.Select(x => new { Size = x }).ToList();
        }

        private void btSaveMau_Click(object sender, EventArgs e)
        {

            if (lbMauIndex.Text == "")
            {
                mausac.Add(tbMau.Text);
                foreach (string i in size)
                {
                    BLL_ClothShop.Instance.AddCTSP("SP00000000", i, tbMau.Text);
                }
            }
            else
            {
                int index = Convert.ToInt32(lbMauIndex.Text);
                foreach (var i in BLL_ClothShop.Instance.GetCTSPByMaSP("SP00000000", "All", mausac[index]))
                {
                    CTSanPham s = new CTSanPham
                    {
                        MaCTSP = i.MaCTSP,
                        MauSac = tbMau.Text,
                        Size = i.Size,
                        SoLuong = i.SoLuong,
                        MaSP = BLL_ClothShop.Instance.GetCTSPByMaCTSP(i.MaCTSP).MaSP,
                    };
                    BLL_ClothShop.Instance.AddUpdateCTSP(s);
                }
                mausac[index] = tbMau.Text;
            }
            dataGridView2.DataSource = mausac.Select(x => new { Mau = x }).ToList();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            if(tbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return;
            }
            if (tbGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá bán");
                return;
            }
            if (Convert.ToInt32(tbGiaBan.Text) == 0)
            {
                MessageBox.Show("Giá bán không thể bằng 0");
                return;
            }
            foreach (char i in tbGiaBan.Text)
            {
                if ((i < '0') || (i > '9'))
                {
                    MessageBox.Show("Giá bán không hợp lệ");
                    tbGiaBan.Text = "0";
                    return;
                }
            }
            SanPham sp = new SanPham
            {
                MaSP = tbMaSP.Text,
                TenSP = tbTenSP.Text,
                ID_NhomSP = ((CBBNhomSP)cbbNhomSP.SelectedItem).Value,
                GiaBan = (tbGiaBan.Text != "") ? Convert.ToInt32(tbGiaBan.Text) : 0,
                KhuyenMai = (tbKhuyenMai.Text != "") ? Convert.ToDouble(tbKhuyenMai.Text)/100 : 0,
            };
            BLL_ClothShop.Instance.AddUpdateSP(sp);
            BLL_ClothShop.Instance.PasteSP(tbMaSP.Text);
            d();
            this.Close();
        }

        private void btDeleteSize_Click(object sender, EventArgs e)
        {
            if (size.Count == 1)
                MessageBox.Show("Phải có ít nhất 1 Size");
            else if (lbSizeIndex.Text != "")
            {
                if (BLL_ClothShop.Instance.CheckDelSize("SP00000000", size[Convert.ToInt32(lbSizeIndex.Text)]))
                {
                    foreach (var i in BLL_ClothShop.Instance.GetCTSPByMaSP("SP00000000", size[Convert.ToInt32(lbSizeIndex.Text)], "All"))
                    {
                        BLL_ClothShop.Instance.DelCTSP(i.MaCTSP);
                    }
                    size.RemoveAt(Convert.ToInt32(lbSizeIndex.Text));
                }
                else
                    MessageBox.Show("Không thể xóa size đã được sử dụng");
            }
            dataGridView1.DataSource = size.Select(x => new { Size = x }).ToList();
        }

        private void btDeleteMau_Click(object sender, EventArgs e)
        {
            if (mausac.Count == 1)
                MessageBox.Show("Phải có ít nhất 1 Màu");
            else if (lbMauIndex.Text != "")
            {
                if (BLL_ClothShop.Instance.CheckDelMau("SP00000000", mausac[Convert.ToInt32(lbMauIndex.Text)]))
                {
                    foreach (var i in BLL_ClothShop.Instance.GetCTSPByMaSP("SP00000000", "All", mausac[Convert.ToInt32(lbMauIndex.Text)]))
                    {
                        BLL_ClothShop.Instance.DelCTSP(i.MaCTSP);
                    }
                    mausac.RemoveAt(Convert.ToInt32(lbMauIndex.Text));
                }
                else
                    MessageBox.Show("Không thể xóa màu đã được sử dụng");
            }
            dataGridView2.DataSource = mausac.Select(x => new { Mau = x }).ToList();
        }
    }
}
