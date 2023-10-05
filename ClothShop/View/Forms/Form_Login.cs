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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picBoxPW_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void picBoxPW_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        public void Login()
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                if (BLL_ClothShop.Instance.CheckLogin(tbUserName.Text, tbPassword.Text))
                {
                    if (BLL_ClothShop.Instance.CheckChucVu(tbUserName.Text) == 0)
                    {
                        Form_Dashboard f = new Form_Dashboard(tbUserName.Text);
                        f.Show();
                    }
                    else if (BLL_ClothShop.Instance.CheckChucVu(tbUserName.Text) == 1)
                    {
                        Form_DB_ThuNgan f = new Form_DB_ThuNgan(tbUserName.Text);
                        f.Show();
                    }
                    else if (BLL_ClothShop.Instance.CheckChucVu(tbUserName.Text) == 2)
                    {
                        Form_DB_BanHang f = new Form_DB_BanHang(tbUserName.Text);
                        f.Show();
                    }
                    else if (BLL_ClothShop.Instance.CheckChucVu(tbUserName.Text) == 3)
                    {
                        Form_DB_NhapKho f = new Form_DB_NhapKho(tbUserName.Text);
                        f.Show();
                    }
                }
                else
                {
                    Form_Message f = new Form_Message("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    f.Show();
                }
            }
            else
            {
                Form_Message f = new Form_Message("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                f.Show();
            }
            tbPassword.Text = "";
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
     
        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }

      
    }
}
