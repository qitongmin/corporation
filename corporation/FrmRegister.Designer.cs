namespace corporation
{
    partial class FrmRegister
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
            this.tboxXh = new System.Windows.Forms.TextBox();
            this.lblXh = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.tboxTel = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoMen = new System.Windows.Forms.RadioButton();
            this.rdoWoMen = new System.Windows.Forms.RadioButton();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxXh
            // 
            this.tboxXh.Location = new System.Drawing.Point(107, 100);
            this.tboxXh.Name = "tboxXh";
            this.tboxXh.Size = new System.Drawing.Size(139, 21);
            this.tboxXh.TabIndex = 0;
            // 
            // lblXh
            // 
            this.lblXh.AutoSize = true;
            this.lblXh.Location = new System.Drawing.Point(60, 103);
            this.lblXh.Name = "lblXh";
            this.lblXh.Size = new System.Drawing.Size(47, 12);
            this.lblXh.TabIndex = 1;
            this.lblXh.Text = "学  号:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(60, 144);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(47, 12);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密  码:";
            // 
            // tboxPwd
            // 
            this.tboxPwd.Location = new System.Drawing.Point(107, 141);
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.PasswordChar = '*';
            this.tboxPwd.Size = new System.Drawing.Size(139, 21);
            this.tboxPwd.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 184);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "姓  名:";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(107, 181);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(139, 21);
            this.tboxName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(60, 224);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 12);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "性  别:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(48, 264);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(59, 12);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "电话号码:";
            // 
            // tboxTel
            // 
            this.tboxTel.Location = new System.Drawing.Point(107, 260);
            this.tboxTel.Name = "tboxTel";
            this.tboxTel.Size = new System.Drawing.Size(139, 21);
            this.tboxTel.TabIndex = 8;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(171, 333);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 10;
            this.btnRes.Text = "注  册";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(62, 333);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 11;
            this.btnCanel.Text = "返回登录";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::corporation.Properties.Resources.fail;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "选择图像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoMen
            // 
            this.rdoMen.AutoSize = true;
            this.rdoMen.Checked = true;
            this.rdoMen.Location = new System.Drawing.Point(114, 224);
            this.rdoMen.Name = "rdoMen";
            this.rdoMen.Size = new System.Drawing.Size(59, 16);
            this.rdoMen.TabIndex = 14;
            this.rdoMen.TabStop = true;
            this.rdoMen.Text = "小帅哥";
            this.rdoMen.UseVisualStyleBackColor = true;
            // 
            // rdoWoMen
            // 
            this.rdoWoMen.AutoSize = true;
            this.rdoWoMen.Location = new System.Drawing.Point(187, 224);
            this.rdoWoMen.Name = "rdoWoMen";
            this.rdoWoMen.Size = new System.Drawing.Size(59, 16);
            this.rdoWoMen.TabIndex = 15;
            this.rdoWoMen.Text = "小姐姐";
            this.rdoWoMen.UseVisualStyleBackColor = true;
            // 
            // txtValidCode
            // 
            this.txtValidCode.Location = new System.Drawing.Point(187, 296);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(59, 21);
            this.txtValidCode.TabIndex = 18;
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(97, 295);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(76, 23);
            this.picValidCode.TabIndex = 17;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "验证码:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 402);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoWoMen);
            this.Controls.Add(this.rdoMen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.tboxTel);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.tboxPwd);
            this.Controls.Add(this.lblXh);
            this.Controls.Add(this.tboxXh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxXh;
        private System.Windows.Forms.Label lblXh;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tboxPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox tboxTel;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoMen;
        private System.Windows.Forms.RadioButton rdoWoMen;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.Label label1;
    }
}