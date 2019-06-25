namespace corporation
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxZh = new System.Windows.Forms.TextBox();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.lblZh = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.comboxSelect = new System.Windows.Forms.ComboBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxZh
            // 
            this.tboxZh.Location = new System.Drawing.Point(83, 27);
            this.tboxZh.Name = "tboxZh";
            this.tboxZh.Size = new System.Drawing.Size(174, 21);
            this.tboxZh.TabIndex = 0;
            // 
            // tboxPwd
            // 
            this.tboxPwd.Location = new System.Drawing.Point(83, 71);
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.Size = new System.Drawing.Size(174, 21);
            this.tboxPwd.TabIndex = 1;
            this.tboxPwd.UseSystemPasswordChar = true;
            // 
            // lblZh
            // 
            this.lblZh.AutoSize = true;
            this.lblZh.BackColor = System.Drawing.Color.Transparent;
            this.lblZh.Location = new System.Drawing.Point(32, 31);
            this.lblZh.Name = "lblZh";
            this.lblZh.Size = new System.Drawing.Size(47, 12);
            this.lblZh.TabIndex = 2;
            this.lblZh.Text = "账  号:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Location = new System.Drawing.Point(33, 75);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(47, 12);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密  码:";
            // 
            // comboxSelect
            // 
            this.comboxSelect.FormattingEnabled = true;
            this.comboxSelect.Items.AddRange(new object[] {
            "学生",
            "社团管理员",
            "超级管理员"});
            this.comboxSelect.Location = new System.Drawing.Point(173, 110);
            this.comboxSelect.Name = "comboxSelect";
            this.comboxSelect.Size = new System.Drawing.Size(84, 20);
            this.comboxSelect.TabIndex = 4;
            this.comboxSelect.Text = "学生";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(83, 186);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 5;
            this.btnRes.Text = "用户注册";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(110, 114);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 12);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "登录类型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "验证码:";
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(71, 147);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(96, 23);
            this.picValidCode.TabIndex = 9;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // txtValidCode
            // 
            this.txtValidCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValidCode.Location = new System.Drawing.Point(173, 148);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(84, 21);
            this.txtValidCode.TabIndex = 10;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::corporation.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(298, 230);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.comboxSelect);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblZh);
            this.Controls.Add(this.tboxPwd);
            this.Controls.Add(this.tboxZh);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生社团信息管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxZh;
        private System.Windows.Forms.TextBox tboxPwd;
        private System.Windows.Forms.Label lblZh;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.ComboBox comboxSelect;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.TextBox txtValidCode;
    }
}

