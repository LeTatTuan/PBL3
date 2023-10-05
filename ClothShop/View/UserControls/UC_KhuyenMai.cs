using ClothShop.BLL;
using ClothShop.View.Forms;
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
    public partial class UC_KhuyenMai : UserControl
    {
        string MaNV;
        public UC_KhuyenMai(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            tbTgLuuKho.Text = "30";
            tbTileBan.Text = "50";
            ReloadKM();
            ReloadGoiY(30, 50);
        }

        public void ReloadKM()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKM();
        }

        public void ReloadGoiY(int thoiGian, double tiLe)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetSPTonKho(thoiGian, tiLe);
        }
        

        private void buttonThemKM_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_DetailKM f = new Form_DetailKM(null))
                {
                    f.d = new Form_DetailKM.Mydel(ReloadKM);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void buttonSuaKM_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    using (Form_DetailKM f = new Form_DetailKM(dataGridView1.SelectedRows[0].Cells["MaKM"].Value.ToString()))
                    {
                        f.d = new Form_DetailKM.Mydel(ReloadKM);
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã khuyến mãi cần sửa");
            }
        }

        private void buttonXoaKM_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaKM = i.Cells["MaKM"].Value.ToString();
                    if(BLL_ClothShop.Instance.CheckDelKM(MaKM))
                    {
                        BLL_ClothShop.Instance.DelKM(MaKM);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá khuyễn mãi này!!!!");
                    }
                }
                ReloadKM();
            }
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllKM(tbSearchKM.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string txt = null;
            if(BLL_ClothShop.Instance.CheckNum(tbTgLuuKho.Text) == -1 || BLL_ClothShop.Instance.CheckNum(tbTileBan.Text) == -1)
            {
                txt = "Không thể rỗng!!!!";
            }
            else if(BLL_ClothShop.Instance.CheckNum(tbTgLuuKho.Text) == 1 || BLL_ClothShop.Instance.CheckNum(tbTileBan.Text) == 11)
            {
                txt = "Thời gian và tỉ lệ bán chỉ chứa các ký tự số!!";
            }
            
            if(txt == null)
            {
                ReloadGoiY(Convert.ToInt32(tbTgLuuKho.Text), Convert.ToDouble(tbTileBan.Text));
            }
            else
            {
                try
                {
                    using (Form_Message f = new Form_Message(txt))
                    {
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
        }
    }
}
