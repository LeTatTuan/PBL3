namespace ClothShop.View.Forms
{
    partial class Form_XacNhanDX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_XacNhanDX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butNo = new System.Windows.Forms.Button();
            this.butYes = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(404, 50);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.labelTitle.Location = new System.Drawing.Point(54, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(104, 25);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Xác nhận";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.butNo);
            this.panel2.Controls.Add(this.butYes);
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 169);
            this.panel2.TabIndex = 1;
            // 
            // butNo
            // 
            this.butNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.butNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.butNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.butNo.Image = ((System.Drawing.Image)(resources.GetObject("butNo.Image")));
            this.butNo.Location = new System.Drawing.Point(233, 96);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(121, 36);
            this.butNo.TabIndex = 2;
            this.butNo.Text = "Không";
            this.butNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butNo.UseVisualStyleBackColor = false;
            this.butNo.Click += new System.EventHandler(this.butNo_Click);
            // 
            // butYes
            // 
            this.butYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.butYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.butYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.butYes.Image = ((System.Drawing.Image)(resources.GetObject("butYes.Image")));
            this.butYes.Location = new System.Drawing.Point(51, 96);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(121, 36);
            this.butYes.TabIndex = 1;
            this.butYes.Text = "Có";
            this.butYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butYes.UseVisualStyleBackColor = false;
            this.butYes.Click += new System.EventHandler(this.butYes_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.labelMsg.Location = new System.Drawing.Point(64, 43);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(362, 25);
            this.labelMsg.TabIndex = 3;
            this.labelMsg.Text = "Bạn có chắc chắn muốn đăng xuất ?";
            // 
            // Form_XacNhanDX
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(209)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(420, 235);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_XacNhanDX";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_XacNhanDX";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Button butYes;
    }
}