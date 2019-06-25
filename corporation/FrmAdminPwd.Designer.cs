namespace corporation
{
    partial class FrmAdminPwd
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
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPwdOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPwdTwo = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账  号:";
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(124, 30);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(100, 21);
            this.tboxUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码:";
            // 
            // tboxPwdOne
            // 
            this.tboxPwdOne.Location = new System.Drawing.Point(124, 71);
            this.tboxPwdOne.Name = "tboxPwdOne";
            this.tboxPwdOne.PasswordChar = '*';
            this.tboxPwdOne.Size = new System.Drawing.Size(100, 21);
            this.tboxPwdOne.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码:";
            // 
            // tboxPwdTwo
            // 
            this.tboxPwdTwo.Location = new System.Drawing.Point(124, 110);
            this.tboxPwdTwo.Name = "tboxPwdTwo";
            this.tboxPwdTwo.PasswordChar = '*';
            this.tboxPwdTwo.Size = new System.Drawing.Size(100, 21);
            this.tboxPwdTwo.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(149, 148);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "修  改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmAdminPwd
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 202);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tboxPwdTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPwdOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminPwd";
            this.Text = "超级管理员账号设置";
            this.Load += new System.EventHandler(this.FrmAdminPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPwdOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPwdTwo;
        private System.Windows.Forms.Button btnSubmit;
    }
}