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
    public partial class Form_AddNhomSP : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        int ID = -1;
        public Form_AddNhomSP()
        {
            InitializeComponent();
            ReLoad();
        }

        public void ReLoad()
        {
            dataGridView1.DataSource = BLL.BLL_ClothShop.Instance.GetAllNhomSP();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            d();
            this.Close();
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            if (tbNhomSP.Text != "" && tbNhomSP.Text != null)
            {
                if (BLL_ClothShop.Instance.GetNhomSPByName(tbNhomSP.Text) == null)
                {
                    NhomSP s = new NhomSP
                    {
                        ID_NhomSP = ID,
                        TenNhomSP = tbNhomSP.Text
                    };
                    BLL_ClothShop.Instance.AddNhomSP(s);
                }
                else
                {
                    MessageBox.Show("Không thể thêm nhóm trùng");
                }
            }
            else MessageBox.Show("Không thể thêm nhóm rỗng");
            tbNhomSP.Text = "";
            ReLoad();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                tbNhomSP.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
