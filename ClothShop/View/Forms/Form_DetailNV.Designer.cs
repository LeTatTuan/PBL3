namespace ClothShop.View.Forms
{
    partial class Form_DetailNV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DetailNV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butThoat = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.gbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.lBMaNV = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.butThoat);
            this.panel1.Controls.Add(this.butLuu);
            this.panel1.Controls.Add(this.cbbChucVu);
            this.panel1.Controls.Add(this.gbGioiTinh);
            this.panel1.Controls.Add(this.tbSDT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTenNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMaNV);
            this.panel1.Controls.Add(this.lBMaNV);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 589);
            this.panel1.TabIndex = 0;
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.butThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.butThoat.Image = ((System.Drawing.Image)(resources.GetObject("butThoat.Image")));
            this.butThoat.Location = new System.Drawing.Point(662, 521);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(141, 49);
            this.butThoat.TabIndex = 2;
            this.butThoat.Text = "Thoát";
            this.butThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butLuu
            // 
            this.butLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.butLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.butLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.Location = new System.Drawing.Point(474, 521);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(141, 49);
            this.butLuu.TabIndex = 2;
            this.butLuu.Text = "Lưu";
            this.butLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butLuu.UseVisualStyleBackColor = false;
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Thu Ngân",
            "Bán Hàng",
            "Nhập Kho"});
            this.cbbChucVu.Location = new System.Drawing.Point(249, 329);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(554, 30);
            this.cbbChucVu.TabIndex = 2;
            // 
            // gbGioiTinh
            // 
            this.gbGioiTinh.Controls.Add(this.rbNu);
            this.gbGioiTinh.Controls.Add(this.rbNam);
            this.gbGioiTinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.gbGioiTinh.Location = new System.Drawing.Point(45, 227);
            this.gbGioiTinh.Name = "gbGioiTinh";
            this.gbGioiTinh.Size = new System.Drawing.Size(758, 61);
            this.gbGioiTinh.TabIndex = 3;
            this.gbGioiTinh.TabStop = false;
            this.gbGioiTinh.Text = "Giới tính:";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(389, 25);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(56, 27);
            this.rbNu.TabIndex = 0;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(204, 25);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(78, 27);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbSDT.Location = new System.Drawing.Point(249, 455);
            this.tbSDT.Multiline = true;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(554, 32);
            this.tbSDT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(41, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbDiaChi.Location = new System.Drawing.Point(249, 391);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(554, 32);
            this.tbDiaChi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(41, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(41, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chức vụ:";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbTenNV.Location = new System.Drawing.Point(249, 161);
            this.tbTenNV.Multiline = true;
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(554, 32);
            this.tbTenNV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(41, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên nhân viên:";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Enabled = false;
            this.tbMaNV.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbMaNV.Location = new System.Drawing.Point(249, 93);
            this.tbMaNV.Multiline = true;
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(554, 32);
            this.tbMaNV.TabIndex = 2;
            // 
            // lBMaNV
            // 
            this.lBMaNV.AutoSize = true;
            this.lBMaNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lBMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.lBMaNV.Location = new System.Drawing.Point(41, 96);
            this.lBMaNV.Name = "lBMaNV";
            this.lBMaNV.Size = new System.Drawing.Size(146, 23);
            this.lBMaNV.TabIndex = 3;
            this.lBMaNV.Text = "Mã nhân viên:";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.lbTitle.Location = new System.Drawing.Point(306, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(219, 32);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Thêm nhân viên";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_DetailNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(889, 605);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DetailNV";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DeitailNV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGioiTinh.ResumeLayout(false);
            this.gbGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label lBMaNV;
        private System.Windows.Forms.GroupBox gbGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butThoat;
    }
}