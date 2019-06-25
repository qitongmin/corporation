namespace corporation
{
    partial class FrmCorAdd
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.lblCorName = new System.Windows.Forms.Label();
            this.tboxCorName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboxCorType = new System.Windows.Forms.ComboBox();
            this.lblPropri = new System.Windows.Forms.Label();
            this.tboxPropri = new System.Windows.Forms.TextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.tboxIntro = new System.Windows.Forms.TextBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.tboxNotice = new System.Windows.Forms.TextBox();
            this.btnCorRes = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.dtpNoticeDate = new System.Windows.Forms.DateTimePicker();
            this.lblNoticeTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::corporation.Properties.Resources.fail;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(186, 45);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 1;
            this.btnImg.Text = "上传头像";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // lblCorName
            // 
            this.lblCorName.AutoSize = true;
            this.lblCorName.Location = new System.Drawing.Point(60, 125);
            this.lblCorName.Name = "lblCorName";
            this.lblCorName.Size = new System.Drawing.Size(59, 12);
            this.lblCorName.TabIndex = 2;
            this.lblCorName.Text = "社团名称:";
            // 
            // tboxCorName
            // 
            this.tboxCorName.Location = new System.Drawing.Point(122, 120);
            this.tboxCorName.Name = "tboxCorName";
            this.tboxCorName.Size = new System.Drawing.Size(100, 21);
            this.tboxCorName.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(58, 168);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 12);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "社团类别:";
            // 
            // cboxCorType
            // 
            this.cboxCorType.FormattingEnabled = true;
            this.cboxCorType.Location = new System.Drawing.Point(122, 165);
            this.cboxCorType.Name = "cboxCorType";
            this.cboxCorType.Size = new System.Drawing.Size(98, 20);
            this.cboxCorType.TabIndex = 5;
            // 
            // lblPropri
            // 
            this.lblPropri.AutoSize = true;
            this.lblPropri.Location = new System.Drawing.Point(68, 206);
            this.lblPropri.Name = "lblPropri";
            this.lblPropri.Size = new System.Drawing.Size(47, 12);
            this.lblPropri.TabIndex = 6;
            this.lblPropri.Text = "社长id:";
            // 
            // tboxPropri
            // 
            this.tboxPropri.Location = new System.Drawing.Point(122, 200);
            this.tboxPropri.Name = "tboxPropri";
            this.tboxPropri.Size = new System.Drawing.Size(100, 21);
            this.tboxPropri.TabIndex = 7;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(60, 227);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(35, 12);
            this.lblIntro.TabIndex = 8;
            this.lblIntro.Text = "介绍:";
            // 
            // tboxIntro
            // 
            this.tboxIntro.Location = new System.Drawing.Point(89, 242);
            this.tboxIntro.Multiline = true;
            this.tboxIntro.Name = "tboxIntro";
            this.tboxIntro.Size = new System.Drawing.Size(133, 51);
            this.tboxIntro.TabIndex = 9;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(60, 296);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(35, 12);
            this.lblNotice.TabIndex = 10;
            this.lblNotice.Text = "公告:";
            // 
            // tboxNotice
            // 
            this.tboxNotice.Location = new System.Drawing.Point(89, 311);
            this.tboxNotice.Multiline = true;
            this.tboxNotice.Name = "tboxNotice";
            this.tboxNotice.Size = new System.Drawing.Size(131, 49);
            this.tboxNotice.TabIndex = 11;
            // 
            // btnCorRes
            // 
            this.btnCorRes.Location = new System.Drawing.Point(186, 419);
            this.btnCorRes.Name = "btnCorRes";
            this.btnCorRes.Size = new System.Drawing.Size(75, 23);
            this.btnCorRes.TabIndex = 12;
            this.btnCorRes.Text = "注  册";
            this.btnCorRes.UseVisualStyleBackColor = true;
            this.btnCorRes.Click += new System.EventHandler(this.btnCorRes_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(62, 419);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 13;
            this.btnCanel.Text = "取  消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // dtpNoticeDate
            // 
            this.dtpNoticeDate.Location = new System.Drawing.Point(132, 379);
            this.dtpNoticeDate.Name = "dtpNoticeDate";
            this.dtpNoticeDate.Size = new System.Drawing.Size(129, 21);
            this.dtpNoticeDate.TabIndex = 14;
            // 
            // lblNoticeTime
            // 
            this.lblNoticeTime.AutoSize = true;
            this.lblNoticeTime.Location = new System.Drawing.Point(42, 384);
            this.lblNoticeTime.Name = "lblNoticeTime";
            this.lblNoticeTime.Size = new System.Drawing.Size(83, 12);
            this.lblNoticeTime.TabIndex = 15;
            this.lblNoticeTime.Text = "公告有效期至:";
            // 
            // FrmCorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 497);
            this.Controls.Add(this.lblNoticeTime);
            this.Controls.Add(this.dtpNoticeDate);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnCorRes);
            this.Controls.Add(this.tboxNotice);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.tboxIntro);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.tboxPropri);
            this.Controls.Add(this.lblPropri);
            this.Controls.Add(this.cboxCorType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tboxCorName);
            this.Controls.Add(this.lblCorName);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCorAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社团添加";
            this.Load += new System.EventHandler(this.FrmCorAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label lblCorName;
        private System.Windows.Forms.TextBox tboxCorName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboxCorType;
        private System.Windows.Forms.Label lblPropri;
        private System.Windows.Forms.TextBox tboxPropri;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox tboxIntro;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TextBox tboxNotice;
        private System.Windows.Forms.Button btnCorRes;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.DateTimePicker dtpNoticeDate;
        private System.Windows.Forms.Label lblNoticeTime;
    }
}