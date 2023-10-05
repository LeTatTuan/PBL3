namespace ClothShop.View.UserControls
{
    partial class UC_NhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRSMK = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 72);
            this.panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(934, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(143, 34);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbSearch.Location = new System.Drawing.Point(161, 18);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(755, 34);
            this.tbSearch.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.buttonRSMK);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(995, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 618);
            this.panel2.TabIndex = 1;
            // 
            // buttonRSMK
            // 
            this.buttonRSMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonRSMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRSMK.FlatAppearance.BorderSize = 0;
            this.buttonRSMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRSMK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonRSMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonRSMK.Image = ((System.Drawing.Image)(resources.GetObject("buttonRSMK.Image")));
            this.buttonRSMK.Location = new System.Drawing.Point(28, 457);
            this.buttonRSMK.Name = "buttonRSMK";
            this.buttonRSMK.Size = new System.Drawing.Size(150, 50);
            this.buttonRSMK.TabIndex = 12;
            this.buttonRSMK.Text = "RS mật khẩu";
            this.buttonRSMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRSMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRSMK.UseVisualStyleBackColor = false;
            this.buttonRSMK.Click += new System.EventHandler(this.buttonRSMK_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.Location = new System.Drawing.Point(28, 348);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(150, 50);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.Location = new System.Drawing.Point(28, 113);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(150, 50);
            this.buttonThem.TabIndex = 9;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.Location = new System.Drawing.Point(28, 231);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(150, 50);
            this.buttonSua.TabIndex = 10;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 618);
            this.dataGridView1.TabIndex = 2;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.Name = "UC_NhanVien";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1200, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonRSMK;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
