using corporation.BLL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class FrmRegister : Form
    {
        byte[] Imgbytes=new byte[1];
        int Type = 0;
        public FrmRegister(int type)
        {
            Type = type;
            InitializeComponent();
        }
        //检查电话号码是否合法
        private bool CheckTel(string tel)
        {
            return Regex.IsMatch(tel, @"^(13|14|15|16|18|19|17)\d{9}$");
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            if(Imgbytes.Length == 1)
            {
                MessageBox.Show("请选择头像!");
                return;
            }
            if (tboxXh.Text.Trim() == "" || tboxPwd.Text.Trim() == "" || tboxName.Text.Trim() == ""  || tboxTel.Text.Trim() == "")
                MessageBox.Show("信息不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (AdminManage.UserXh(tboxXh.Text.Trim()))
            {
                MessageBox.Show("学号已存在！");
            }
            else if (tboxPwd.Text.Length<6)
            {
                MessageBox.Show("密码不足6位");
            }
            else if (!CheckTel(tboxTel.Text.Trim()))
            {
                MessageBox.Show("手机号码不合法！");
            }
            else if (txtValidCode.Text.Trim() == "")
            {
                MessageBox.Show("请输入验证码!");
            }
            else if (!txtValidCode.Text.Equals(validCode.CheckCode))
            {
                MessageBox.Show("验证码不正确!");
                txtValidCode.Text = "";
            }
            else
            {
                //获取性别
                string Gender="";
                if (rdoMen.Checked)
                {
                    Gender = "小帅哥";
                }
                else
                {
                    Gender = "小姐姐";
                }
                //密码md5加密
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] palindata = Encoding.Default.GetBytes(tboxPwd.Text.Trim());//将要加密的字符串转换为字节数组
                byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
                string userPwd = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串

                User u = new User(tboxXh.Text.Trim(), userPwd, tboxName.Text.Trim(), tboxTel.Text.Trim(), Gender, Imgbytes);
                if (UserManage.UserRes(u))
                {
                    MessageBox.Show("注册成功！");
                    this.Hide();
                    if (Type == 1)
                    {
                        FrmLogin LoginForm = new FrmLogin();
                        LoginForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }
            picValidCode_Click(sender,e);
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin LoginForm = new FrmLogin();
            LoginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
        ValidCode validCode = new ValidCode(4, ValidCode.CodeType.Numbers);//实例化这个对象(长度，模式)
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片
            if (Type == 0)
            {
                btnCanel.Hide();
            }
        }

        private void picValidCode_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }
    }
}
