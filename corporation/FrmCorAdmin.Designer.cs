namespace corporation
{
    partial class FrmCorAdmin
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblCretime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIntroduce = new System.Windows.Forms.Label();
            this.lblCorPeo = new System.Windows.Forms.Label();
            this.lblCorName = new System.Windows.Forms.Label();
            this.pboxLOGO = new System.Windows.Forms.PictureBox();
            this.tboxCorName = new System.Windows.Forms.TextBox();
            this.tboxCorType = new System.Windows.Forms.TextBox();
            this.tboxCorPeo = new System.Windows.Forms.TextBox();
            this.tboxCorCretime = new System.Windows.Forms.TextBox();
            this.tboxIntroduce = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCorAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxUserXh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvCorUser = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelUnuseTime = new System.Windows.Forms.Button();
            this.btnHeadImg = new System.Windows.Forms.Button();
            this.lblNoticeContent = new System.Windows.Forms.Label();
            this.tboxNoticeContent = new System.Windows.Forms.TextBox();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.lblTimeBegin = new System.Windows.Forms.Label();
            this.tboxNoticeCorId = new System.Windows.Forms.TextBox();
            this.lblNoyiceCorId = new System.Windows.Forms.Label();
            this.btnnoticeRemove = new System.Windows.Forms.Button();
            this.btnNoticeMod = new System.Windows.Forms.Button();
            this.btnNoticeAdd = new System.Windows.Forms.Button();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLOGO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorUser)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(275, 100);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 15);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "社团类别:";
            // 
            // lblCretime
            // 
            this.lblCretime.AutoSize = true;
            this.lblCretime.Location = new System.Drawing.Point(616, 100);
            this.lblCretime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCretime.Name = "lblCretime";
            this.lblCretime.Size = new System.Drawing.Size(75, 15);
            this.lblCretime.TabIndex = 39;
            this.lblCretime.Text = "创建时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 38;
            // 
            // lblIntroduce
            // 
            this.lblIntroduce.AutoSize = true;
            this.lblIntroduce.Location = new System.Drawing.Point(275, 156);
            this.lblIntroduce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroduce.Name = "lblIntroduce";
            this.lblIntroduce.Size = new System.Drawing.Size(45, 15);
            this.lblIntroduce.TabIndex = 32;
            this.lblIntroduce.Text = "介绍:";
            // 
            // lblCorPeo
            // 
            this.lblCorPeo.AutoSize = true;
            this.lblCorPeo.Location = new System.Drawing.Point(643, 58);
            this.lblCorPeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorPeo.Name = "lblCorPeo";
            this.lblCorPeo.Size = new System.Drawing.Size(45, 15);
            this.lblCorPeo.TabIndex = 30;
            this.lblCorPeo.Text = "社长:";
            // 
            // lblCorName
            // 
            this.lblCorName.AutoSize = true;
            this.lblCorName.Location = new System.Drawing.Point(275, 58);
            this.lblCorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorName.Name = "lblCorName";
            this.lblCorName.Size = new System.Drawing.Size(75, 15);
            this.lblCorName.TabIndex = 28;
            this.lblCorName.Text = "社团名称:";
            // 
            // pboxLOGO
            // 
            this.pboxLOGO.Location = new System.Drawing.Point(31, 51);
            this.pboxLOGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxLOGO.Name = "pboxLOGO";
            this.pboxLOGO.Size = new System.Drawing.Size(148, 118);
            this.pboxLOGO.TabIndex = 27;
            this.pboxLOGO.TabStop = false;
            // 
            // tboxCorName
            // 
            this.tboxCorName.Location = new System.Drawing.Point(361, 54);
            this.tboxCorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCorName.Name = "tboxCorName";
            this.tboxCorName.Size = new System.Drawing.Size(151, 25);
            this.tboxCorName.TabIndex = 41;
            // 
            // tboxCorType
            // 
            this.tboxCorType.Location = new System.Drawing.Point(361, 96);
            this.tboxCorType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCorType.Name = "tboxCorType";
            this.tboxCorType.Size = new System.Drawing.Size(151, 25);
            this.tboxCorType.TabIndex = 42;
            // 
            // tboxCorPeo
            // 
            this.tboxCorPeo.Location = new System.Drawing.Point(697, 54);
            this.tboxCorPeo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCorPeo.Name = "tboxCorPeo";
            this.tboxCorPeo.Size = new System.Drawing.Size(151, 25);
            this.tboxCorPeo.TabIndex = 43;
            // 
            // tboxCorCretime
            // 
            this.tboxCorCretime.Location = new System.Drawing.Point(697, 95);
            this.tboxCorCretime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCorCretime.Name = "tboxCorCretime";
            this.tboxCorCretime.Size = new System.Drawing.Size(151, 25);
            this.tboxCorCretime.TabIndex = 44;
            // 
            // tboxIntroduce
            // 
            this.tboxIntroduce.Location = new System.Drawing.Point(277, 180);
            this.tboxIntroduce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxIntroduce.Multiline = true;
            this.tboxIntroduce.Name = "tboxIntroduce";
            this.tboxIntroduce.Size = new System.Drawing.Size(571, 85);
            this.tboxIntroduce.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCorAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxUserXh);
            this.groupBox1.Location = new System.Drawing.Point(16, 780);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 81);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成员添加:";
            // 
            // btnCorAdd
            // 
            this.btnCorAdd.Location = new System.Drawing.Point(328, 22);
            this.btnCorAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCorAdd.Name = "btnCorAdd";
            this.btnCorAdd.Size = new System.Drawing.Size(100, 29);
            this.btnCorAdd.TabIndex = 2;
            this.btnCorAdd.Text = "添  加";
            this.btnCorAdd.Click += new System.EventHandler(this.btnCorAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户账号:";
            // 
            // tboxUserXh
            // 
            this.tboxUserXh.Location = new System.Drawing.Point(131, 25);
            this.tboxUserXh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxUserXh.Name = "tboxUserXh";
            this.tboxUserXh.Size = new System.Drawing.Size(188, 25);
            this.tboxUserXh.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.dgvCorUser);
            this.groupBox2.Location = new System.Drawing.Point(19, 876);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1076, 236);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成员删除";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(895, 44);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 29);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "删  除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvCorUser
            // 
            this.dgvCorUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorUser.Location = new System.Drawing.Point(52, 25);
            this.dgvCorUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCorUser.Name = "dgvCorUser";
            this.dgvCorUser.RowTemplate.Height = 23;
            this.dgvCorUser.Size = new System.Drawing.Size(808, 121);
            this.dgvCorUser.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(733, 270);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 29);
            this.btnSubmit.TabIndex = 49;
            this.btnSubmit.Text = "提  交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(603, 270);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "清  空";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelUnuseTime);
            this.groupBox3.Controls.Add(this.btnHeadImg);
            this.groupBox3.Controls.Add(this.lblNoticeContent);
            this.groupBox3.Controls.Add(this.tboxNoticeContent);
            this.groupBox3.Controls.Add(this.dtpTimeEnd);
            this.groupBox3.Controls.Add(this.lblTimeEnd);
            this.groupBox3.Controls.Add(this.dtpBeginTime);
            this.groupBox3.Controls.Add(this.lblTimeBegin);
            this.groupBox3.Controls.Add(this.tboxNoticeCorId);
            this.groupBox3.Controls.Add(this.lblNoyiceCorId);
            this.groupBox3.Controls.Add(this.btnnoticeRemove);
            this.groupBox3.Controls.Add(this.btnNoticeMod);
            this.groupBox3.Controls.Add(this.btnNoticeAdd);
            this.groupBox3.Controls.Add(this.dgvNotice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Location = new System.Drawing.Point(16, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1079, 744);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "社团信息管理";
            // 
            // btnDelUnuseTime
            // 
            this.btnDelUnuseTime.Location = new System.Drawing.Point(820, 554);
            this.btnDelUnuseTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelUnuseTime.Name = "btnDelUnuseTime";
            this.btnDelUnuseTime.Size = new System.Drawing.Size(149, 29);
            this.btnDelUnuseTime.TabIndex = 65;
            this.btnDelUnuseTime.Text = "一键删除过期公告";
            this.btnDelUnuseTime.UseVisualStyleBackColor = true;
            this.btnDelUnuseTime.Click += new System.EventHandler(this.btnDelUnuseTime_Click);
            // 
            // btnHeadImg
            // 
            this.btnHeadImg.Location = new System.Drawing.Point(31, 166);
            this.btnHeadImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeadImg.Name = "btnHeadImg";
            this.btnHeadImg.Size = new System.Drawing.Size(100, 29);
            this.btnHeadImg.TabIndex = 64;
            this.btnHeadImg.Text = "修改图片";
            this.btnHeadImg.UseVisualStyleBackColor = true;
            this.btnHeadImg.Click += new System.EventHandler(this.btnHeadImg_Click);
            // 
            // lblNoticeContent
            // 
            this.lblNoticeContent.AutoSize = true;
            this.lblNoticeContent.Location = new System.Drawing.Point(13, 610);
            this.lblNoticeContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoticeContent.Name = "lblNoticeContent";
            this.lblNoticeContent.Size = new System.Drawing.Size(45, 15);
            this.lblNoticeContent.TabIndex = 63;
            this.lblNoticeContent.Text = "内容:";
            // 
            // tboxNoticeContent
            // 
            this.tboxNoticeContent.Location = new System.Drawing.Point(79, 610);
            this.tboxNoticeContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNoticeContent.Multiline = true;
            this.tboxNoticeContent.Name = "tboxNoticeContent";
            this.tboxNoticeContent.Size = new System.Drawing.Size(889, 106);
            this.tboxNoticeContent.TabIndex = 62;
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Location = new System.Drawing.Point(641, 556);
            this.dtpTimeEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(139, 25);
            this.dtpTimeEnd.TabIndex = 61;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(557, 561);
            this.lblTimeEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(75, 15);
            this.lblTimeEnd.TabIndex = 60;
            this.lblTimeEnd.Text = "失效时间:";
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Location = new System.Drawing.Point(348, 556);
            this.dtpBeginTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(139, 25);
            this.dtpBeginTime.TabIndex = 59;
            // 
            // lblTimeBegin
            // 
            this.lblTimeBegin.AutoSize = true;
            this.lblTimeBegin.Location = new System.Drawing.Point(264, 561);
            this.lblTimeBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeBegin.Name = "lblTimeBegin";
            this.lblTimeBegin.Size = new System.Drawing.Size(75, 15);
            this.lblTimeBegin.TabIndex = 58;
            this.lblTimeBegin.Text = "开始时间:";
            // 
            // tboxNoticeCorId
            // 
            this.tboxNoticeCorId.Location = new System.Drawing.Point(79, 556);
            this.tboxNoticeCorId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNoticeCorId.Name = "tboxNoticeCorId";
            this.tboxNoticeCorId.Size = new System.Drawing.Size(132, 25);
            this.tboxNoticeCorId.TabIndex = 57;
            // 
            // lblNoyiceCorId
            // 
            this.lblNoyiceCorId.AutoSize = true;
            this.lblNoyiceCorId.Location = new System.Drawing.Point(11, 560);
            this.lblNoyiceCorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoyiceCorId.Name = "lblNoyiceCorId";
            this.lblNoyiceCorId.Size = new System.Drawing.Size(61, 15);
            this.lblNoyiceCorId.TabIndex = 56;
            this.lblNoyiceCorId.Text = "社团Id:";
            // 
            // btnnoticeRemove
            // 
            this.btnnoticeRemove.Location = new System.Drawing.Point(869, 500);
            this.btnnoticeRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnoticeRemove.Name = "btnnoticeRemove";
            this.btnnoticeRemove.Size = new System.Drawing.Size(100, 29);
            this.btnnoticeRemove.TabIndex = 55;
            this.btnnoticeRemove.Text = "删  除";
            this.btnnoticeRemove.UseVisualStyleBackColor = true;
            this.btnnoticeRemove.Click += new System.EventHandler(this.btnnoticeRemove_Click);
            // 
            // btnNoticeMod
            // 
            this.btnNoticeMod.Location = new System.Drawing.Point(869, 421);
            this.btnNoticeMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoticeMod.Name = "btnNoticeMod";
            this.btnNoticeMod.Size = new System.Drawing.Size(100, 29);
            this.btnNoticeMod.TabIndex = 54;
            this.btnNoticeMod.Text = "修  改";
            this.btnNoticeMod.UseVisualStyleBackColor = true;
            this.btnNoticeMod.Click += new System.EventHandler(this.btnNoticeMod_Click);
            // 
            // btnNoticeAdd
            // 
            this.btnNoticeAdd.Location = new System.Drawing.Point(869, 341);
            this.btnNoticeAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoticeAdd.Name = "btnNoticeAdd";
            this.btnNoticeAdd.Size = new System.Drawing.Size(100, 29);
            this.btnNoticeAdd.TabIndex = 53;
            this.btnNoticeAdd.Text = "添  加";
            this.btnNoticeAdd.UseVisualStyleBackColor = true;
            this.btnNoticeAdd.Click += new System.EventHandler(this.btnNoticeAdd_Click);
            // 
            // dgvNotice
            // 
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Location = new System.Drawing.Point(13, 341);
            this.dgvNotice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(820, 188);
            this.dgvNotice.TabIndex = 52;
            this.dgvNotice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotice_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "社团公告:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(869, 270);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "刷新";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmCorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 1052);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxIntroduce);
            this.Controls.Add(this.tboxCorCretime);
            this.Controls.Add(this.tboxCorPeo);
            this.Controls.Add(this.tboxCorType);
            this.Controls.Add(this.tboxCorName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCretime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIntroduce);
            this.Controls.Add(this.lblCorPeo);
            this.Controls.Add(this.lblCorName);
            this.Controls.Add(this.pboxLOGO);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCorAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社团管理员后台首页";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCorAdmin_FormClosed);
            this.Load += new System.EventHandler(this.CorAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLOGO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorUser)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCretime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIntroduce;
        private System.Windows.Forms.Label lblCorPeo;
        private System.Windows.Forms.Label lblCorName;
        private System.Windows.Forms.PictureBox pboxLOGO;
        private System.Windows.Forms.TextBox tboxCorName;
        private System.Windows.Forms.TextBox tboxCorType;
        private System.Windows.Forms.TextBox tboxCorPeo;
        private System.Windows.Forms.TextBox tboxCorCretime;
        private System.Windows.Forms.TextBox tboxIntroduce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCorAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxUserXh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvCorUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblNoticeContent;
        private System.Windows.Forms.TextBox tboxNoticeContent;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.Label lblTimeBegin;
        private System.Windows.Forms.TextBox tboxNoticeCorId;
        private System.Windows.Forms.Label lblNoyiceCorId;
        private System.Windows.Forms.Button btnnoticeRemove;
        private System.Windows.Forms.Button btnNoticeMod;
        private System.Windows.Forms.Button btnNoticeAdd;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHeadImg;
        private System.Windows.Forms.Button btnDelUnuseTime;
    }
}