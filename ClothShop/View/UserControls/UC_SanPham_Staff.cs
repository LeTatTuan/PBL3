using ClothShop.BLL;
using System.Windows.Forms;

namespace ClothShop.View.UserControls
{
    public partial class UC_SanPham_Staff : UserControl
    {
        public UC_SanPham_Staff()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllSP();
            dataGridView2.DataSource = null;
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                tbMaSP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cbbSize.Items.Clear();
                cbbSize.Items.Add("All");
                cbbSize.SelectedIndex = 0;
                foreach (string i in BLL_ClothShop.Instance.GetCBBSizeByMaSP(tbMaSP.Text))
                {
                    cbbSize.Items.Add(i);
                }

                cbbMau.Items.Clear();
                cbbMau.Items.Add("All");
                cbbMau.SelectedIndex = 0;
                foreach (string i in BLL_ClothShop.Instance.GetCBBMauByMaSP(tbMaSP.Text))
                {
                    cbbMau.Items.Add(i);
                }
                dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
            }
        }

        private void cbbSize_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
        }

        private void cbbMau_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridView2.DataSource = BLL_ClothShop.Instance.GetCTSPByMaSP(tbMaSP.Text, cbbSize.Text, cbbMau.Text);
        }

        private void buttonTK_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = BLL_ClothShop.Instance.GetAllSP(tbSearch.Text);
        }
    }
}
