namespace ClothShop.View.Forms
{
    partial class Form_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Message));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 50);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.labelTitle.Location = new System.Drawing.Point(44, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(116, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Thông báo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.butOK);
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 169);
            this.panel2.TabIndex = 1;
            // 
            // butOK
            // 
            this.butOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.butOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.butOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.butOK.Image = ((System.Drawing.Image)(resources.GetObject("butOK.Image")));
            this.butOK.Location = new System.Drawing.Point(192, 100);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(131, 36);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "Đồng ý";
            this.butOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butOK.UseVisualStyleBackColor = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.labelMsg.Location = new System.Drawing.Point(60, 43);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(468, 25);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            // 
            // Form_Message
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(538, 235);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Message";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button butOK;
    }
}