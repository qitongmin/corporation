using corporation.BLL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //登录界面->登录按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tboxZh.Text.Trim() == "" || tboxPwd.Text.Trim() == "")
                MessageBox.Show("用户名或密码为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtValidCode.Text.Trim() == "")
            {
                MessageBox.Show("请输入验证码!");
            }else if (!txtValidCode.Text.Equals(validCode.CheckCode))
            {
                MessageBox.Show("验证码不正确!");
                txtValidCode.Text = "";
            }
            else
            {
                //密码md5加密
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] palindata = Encoding.Default.GetBytes(tboxPwd.Text.Trim());//将要加密的字符串转换为字节数组
                byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
                string userPwd = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串

                User u = new User(tboxZh.Text.Trim(), userPwd);
                Admin u2 = new Admin(tboxZh.Text.Trim(), userPwd);
                if (comboxSelect.SelectedIndex==0)  //学生
                {
                    if (UserManage.UserLogin(u))
                    {
                        this.Hide();
                        UserInterface UserInterfaceForm = new UserInterface();
                        UserInterfaceForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (comboxSelect.SelectedIndex == 1)  //社团管理员
                {
                    if (UserManage.CorUserLogin(u))
                    {
                        this.Hide();
                        FrmCorAdmin CorAdmin = new FrmCorAdmin();
                        CorAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (comboxSelect.SelectedIndex == 2)  //超级管理员
                {
                    if (UserManage.AdminUserLogin(u2))
                    {
                        this.Hide();
                        FrmAdmin AdminForm = new FrmAdmin();
                        AdminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else    //出现选择其他的情况
                {
                    MessageBox.Show("请正确选择！");
                }
            }
            //密码框设置空，获取焦点
            tboxPwd.Text = "";
            tboxPwd.Focus();
            picValidCode_Click(sender, e);
        }
        //登录界面->注册按钮
        private void btnRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister ResForm = new FrmRegister(1);
            ResForm.Show();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        ValidCode validCode = new ValidCode(4, ValidCode.CodeType.Numbers);//实例化这个对象(长度，模式)
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片
        }

        private void picValidCode_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }
    }
}
