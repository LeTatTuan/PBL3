using ClothShop.BLL;
using ClothShop.View.Forms;
using System;
using System.Windows.Forms;

namespace ClothShop.View.UserControls
{
    public partial class UC_NhapKho : UserControl
    {
        string MaNV;
        public UC_NhapKho(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
            ReLoad();
        }

        public void ReLoad()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNK();
            dataGridView2.DataSource = null;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           try
            {
                using (Form_DetailNK f = new Form_DetailNK(null, MaNV))
                {
                    f.d = new Form_DetailNK.Mydel(ReLoad);
                    f.ShowDialog();
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    using (Forms.Form_DetailNK f = new Forms.Form_DetailNK(dataGridView1.SelectedRows[0].Cells["MaNK"].Value.ToString(), MaNV))
                    {
                        f.d = new Form_DetailNK.Mydel(ReLoad);
                        f.ShowDialog();
                        this.OnLoad(e);
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                tbMaNK.Text = dataGridView1.SelectedRows[0].Cells["MaNK"].Value.ToString();
                dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTNKByMaNK(tbMaNK.Text);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaNK = i.Cells["MaNK"].Value.ToString();
                    BLL_ClothShop.Instance.DelNK(MaNK);
                }
                ReLoad();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllNK(tbSearch.Text);
        }
    }
}
