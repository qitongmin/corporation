using corporation.BLL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class FrmCorAdd : Form
    {
        byte[] Imgbytes=new byte[1];
        DataTable dt;
        public FrmCorAdd()
        {
            InitializeComponent();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请选择本地的一张图片";
            openfile.Filter = "Login图片(*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                try
                {
                    //读成二进制
                    Imgbytes = File.ReadAllBytes(openfile.FileName);
                    pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(Imgbytes));
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    MessageBox.Show("出错了！");
                }
            }
        }

        private void FrmCorAdd_Load(object sender, EventArgs e)
        {
            //日期控件时间禁用
            dtpNoticeDate.MinDate = DateTime.Now;
            //获取社团类别
            dt = CorManage.GetCorTypeList();
            //MessageBox.Show(dt.Rows[0][0].ToString());
            for (int i=0;i<dt.Rows.Count;i++)
            {
                cboxCorType.Items.Add(dt.Rows[i][0].ToString());
            }
            cboxCorType.SelectedIndex = 0;

        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCorRes_Click(object sender, EventArgs e)
        {
            if (Imgbytes.Length == 1)
            {
                MessageBox.Show("请选择一张图片");
                return;
            }
            if (tboxCorName.Text.Trim()==""|| tboxPropri.Text.Trim() == ""|| tboxIntro.Text.Trim() == ""|| tboxNotice.Text.Trim() == "")
            {
                MessageBox.Show("信息为空！");
            }
            else
            {
                //根据类别名称获取社团类别ID
                int CorTypeId=1;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cboxCorType.Items.Add(dt.Rows[i][0].ToString());
                    if(dt.Rows[i][0].ToString()== cboxCorType.Text)
                    {
                        CorTypeId = (int)dt.Rows[i][1];
                    }
                }
                //获取当前时间
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //获取公告有效期
                string noticeDate = dtpNoticeDate.Value.ToString();

                Cor c = new Cor(CorTypeId, tboxCorName.Text.Trim(), time, int.Parse(tboxPropri.Text), tboxIntro.Text.Trim(), Imgbytes);
                if (AdminManage.CorAdd(c))
                {
                    //添加社长成为该社团的成员
                    //社团id
                    int CorId = AdminManage.FindCorId();
                    if (AdminManage.UserCorIdUpdate(int.Parse(tboxPropri.Text),CorId))
                    {
                        Notice n = new Notice(CorId, tboxNotice.Text, time, noticeDate);
                        //添加公告到公告表
                        if (AdminManage.AddNotice(n))
                        {
                            MessageBox.Show("添加成功!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("公告添加失败！");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
        }
    }
}
