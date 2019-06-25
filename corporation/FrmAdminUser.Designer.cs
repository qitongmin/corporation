namespace corporation
{
    partial class FrmAdminUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.操作 = new System.Windows.Forms.GroupBox();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModHeadImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxXh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.操作.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入学号或者姓名:";
            // 
            // tboxFind
            // 
            this.tboxFind.Location = new System.Drawing.Point(170, 13);
            this.tboxFind.Name = "tboxFind";
            this.tboxFind.Size = new System.Drawing.Size(149, 21);
            this.tboxFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(330, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查  找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // 操作
            // 
            this.操作.Controls.Add(this.cboxGender);
            this.操作.Controls.Add(this.tboxPwd);
            this.操作.Controls.Add(this.label7);
            this.操作.Controls.Add(this.tboxCorID);
            this.操作.Controls.Add(this.label6);
            this.操作.Controls.Add(this.button5);
            this.操作.Controls.Add(this.btnRemove);
            this.操作.Controls.Add(this.btnMod);
            this.操作.Controls.Add(this.button2);
            this.操作.Controls.Add(this.btnModHeadImg);
            this.操作.Controls.Add(this.pictureBox1);
            this.操作.Controls.Add(this.btnFind);
            this.操作.Controls.Add(this.tboxFind);
            this.操作.Controls.Add(this.label1);
            this.操作.Controls.Add(this.label5);
            this.操作.Controls.Add(this.tboxTel);
            this.操作.Controls.Add(this.label4);
            this.操作.Controls.Add(this.tboxName);
            this.操作.Controls.Add(this.label3);
            this.操作.Controls.Add(this.tboxXh);
            this.操作.Controls.Add(this.label2);
            this.操作.Controls.Add(this.dgvUser);
            this.操作.Location = new System.Drawing.Point(13, 12);
            this.操作.Name = "操作";
            this.操作.Size = new System.Drawing.Size(682, 546);
            this.操作.TabIndex = 1;
            this.操作.TabStop = false;
            this.操作.Text = "操  作";
            // 
            // tboxPwd
            // 
            this.tboxPwd.Location = new System.Drawing.Point(254, 408);
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.Size = new System.Drawing.Size(100, 21);
            this.tboxPwd.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "密码:";
            // 
            // tboxCorID
            // 
            this.tboxCorID.Location = new System.Drawing.Point(254, 461);
            this.tboxCorID.Name = "tboxCorID";
            this.tboxCorID.Size = new System.Drawing.Size(100, 21);
            this.tboxCorID.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "性别:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "重  置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(386, 506);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "删  除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(298, 506);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "修  改";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "添  加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModHeadImg
            // 
            this.btnModHeadImg.Location = new System.Drawing.Point(37, 506);
            this.btnModHeadImg.Name = "btnModHeadImg";
            this.btnModHeadImg.Size = new System.Drawing.Size(75, 23);
            this.btnModHeadImg.TabIndex = 14;
            this.btnModHeadImg.Text = "修改头像";
            this.btnModHeadImg.UseVisualStyleBackColor = true;
            this.btnModHeadImg.Click += new System.EventHandler(this.btnModHeadImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::corporation.Properties.Resources.fail;
            this.pictureBox1.Location = new System.Drawing.Point(24, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "社团id:";
            // 
            // tboxTel
            // 
            this.tboxTel.Location = new System.Drawing.Point(454, 461);
            this.tboxTel.Name = "tboxTel";
            this.tboxTel.Size = new System.Drawing.Size(100, 21);
            this.tboxTel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "电话:";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(454, 367);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 21);
            this.tboxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名:";
            // 
            // tboxXh
            // 
            this.tboxXh.Location = new System.Drawing.Point(254, 365);
            this.tboxXh.Name = "tboxXh";
            this.tboxXh.Size = new System.Drawing.Size(100, 21);
            this.tboxXh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号:";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(24, 45);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(629, 301);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // cboxGender
            // 
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Items.AddRange(new object[] {
            "小帅哥",
            "小姐姐"});
            this.cboxGender.Location = new System.Drawing.Point(454, 409);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(100, 20);
            this.cboxGender.TabIndex = 24;
            // 
            // FrmAdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 569);
            this.Controls.Add(this.操作);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息管理-超级管理员";
            this.Load += new System.EventHandler(this.FrmAdminUser_Load);
            this.操作.ResumeLayout(false);
            this.操作.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox 操作;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModHeadImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxXh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxCorID;
        private System.Windows.Forms.TextBox tboxPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxGender;
    }
}