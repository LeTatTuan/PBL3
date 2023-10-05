namespace ClothShop.View.UserControls
{
    partial class UC_KH_ThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KH_ThuNgan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonXoaKH = new System.Windows.Forms.Button();
            this.buttonThemKH = new System.Windows.Forms.Button();
            this.buttonSuaKH = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1290, 72);
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
            this.buttonSearch.Location = new System.Drawing.Point(933, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(143, 34);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(161, 18);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(750, 34);
            this.tbSearch.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.buttonXoaKH);
            this.panel2.Controls.Add(this.buttonThemKH);
            this.panel2.Controls.Add(this.buttonSuaKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1095, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 618);
            this.panel2.TabIndex = 1;
            // 
            // buttonXoaKH
            // 
            this.buttonXoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoaKH.FlatAppearance.BorderSize = 0;
            this.buttonXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonXoaKH.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoaKH.Image")));
            this.buttonXoaKH.Location = new System.Drawing.Point(25, 402);
            this.buttonXoaKH.Name = "buttonXoaKH";
            this.buttonXoaKH.Size = new System.Drawing.Size(150, 50);
            this.buttonXoaKH.TabIndex = 14;
            this.buttonXoaKH.Text = "Xóa";
            this.buttonXoaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoaKH.UseVisualStyleBackColor = false;
            this.buttonXoaKH.Click += new System.EventHandler(this.buttonXoaKH_Click);
            // 
            // buttonThemKH
            // 
            this.buttonThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThemKH.FlatAppearance.BorderSize = 0;
            this.buttonThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonThemKH.Image = ((System.Drawing.Image)(resources.GetObject("buttonThemKH.Image")));
            this.buttonThemKH.Location = new System.Drawing.Point(25, 167);
            this.buttonThemKH.Name = "buttonThemKH";
            this.buttonThemKH.Size = new System.Drawing.Size(150, 50);
            this.buttonThemKH.TabIndex = 12;
            this.buttonThemKH.Text = "Thêm";
            this.buttonThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThemKH.UseVisualStyleBackColor = false;
            this.buttonThemKH.Click += new System.EventHandler(this.buttonThemKH_Click);
            // 
            // buttonSuaKH
            // 
            this.buttonSuaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.buttonSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuaKH.FlatAppearance.BorderSize = 0;
            this.buttonSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.buttonSuaKH.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuaKH.Image")));
            this.buttonSuaKH.Location = new System.Drawing.Point(25, 285);
            this.buttonSuaKH.Name = "buttonSuaKH";
            this.buttonSuaKH.Size = new System.Drawing.Size(150, 50);
            this.buttonSuaKH.TabIndex = 13;
            this.buttonSuaKH.Text = "Sửa";
            this.buttonSuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSuaKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSuaKH.UseVisualStyleBackColor = false;
            this.buttonSuaKH.Click += new System.EventHandler(this.buttonSuaKH_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 618);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(183)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 618);
            this.dataGridView1.TabIndex = 0;
            // 
            // UC_KH_ThuNgan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.Name = "UC_KH_ThuNgan";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1300, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonXoaKH;
        private System.Windows.Forms.Button buttonThemKH;
        private System.Windows.Forms.Button buttonSuaKH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

