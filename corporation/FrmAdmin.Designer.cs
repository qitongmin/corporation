namespace corporation
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tsbtnUser = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCorMes = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCorType = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUser,
            this.tsbtnCorMes,
            this.tsbtnCorType,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1233, 844);
            this.MainPanel.TabIndex = 1;
            // 
            // tsbtnUser
            // 
            this.tsbtnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUser.Image")));
            this.tsbtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUser.Name = "tsbtnUser";
            this.tsbtnUser.Size = new System.Drawing.Size(84, 22);
            this.tsbtnUser.Text = "用户信息管理";
            this.tsbtnUser.Click += new System.EventHandler(this.tsbtnUser_Click);
            // 
            // tsbtnCorMes
            // 
            this.tsbtnCorMes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCorMes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCorMes.Image")));
            this.tsbtnCorMes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCorMes.Name = "tsbtnCorMes";
            this.tsbtnCorMes.Size = new System.Drawing.Size(84, 22);
            this.tsbtnCorMes.Text = "社团信息管理";
            this.tsbtnCorMes.Click += new System.EventHandler(this.tsbtnCorMes_Click);
            // 
            // tsbtnCorType
            // 
            this.tsbtnCorType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCorType.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCorType.Image")));
            this.tsbtnCorType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCorType.Name = "tsbtnCorType";
            this.tsbtnCorType.Size = new System.Drawing.Size(84, 22);
            this.tsbtnCorType.Text = "社团类型管理";
            this.tsbtnCorType.Click += new System.EventHandler(this.tsbtnCorType_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "账号设置";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超级管理员";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnUser;
        private System.Windows.Forms.ToolStripButton tsbtnCorMes;
        private System.Windows.Forms.ToolStripButton tsbtnCorType;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}