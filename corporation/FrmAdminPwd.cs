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
    public partial class FrmAdminPwd : Form
    {
        public FrmAdminPwd()
        {
            InitializeComponent();
        }

        private void FrmAdminPwd_Load(object sender, EventArgs e)
        {
            tboxUser.Text = AdminManage.GetAdmin(ProgramDate.NowAdminId);
            tboxPwdOne.Text = "";
            tboxPwdTwo.Text = "";
            tboxUser.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //密码md5加密
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(tboxPwdOne.Text.Trim());//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            string userPwd = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串


            if (tboxUser.Text.Trim() == "" || tboxPwdOne.Text.Trim() == "" || tboxPwdTwo.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空!");
            }
            else if (tboxPwdOne.Text.Trim() != tboxPwdTwo.Text.Trim())
            {
                MessageBox.Show("密码不一致!");
            }
            else
            {
                if (AdminManage.UpdateAdmin(ProgramDate.NowAdminId, tboxUser.Text.Trim(), userPwd))
                {
                    MessageBox.Show("修改超级管理员信息成功");
                    FrmAdminPwd_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("失败");
                }
            }
        }
    }
}
