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
    public partial class UserPwdUpdate : Form
    {
        public UserPwdUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //密码md5加密
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(tboxnewone.Text.Trim());//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            string userPwd = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串

            if (tboxnewone.Text == tboxnewtwo.Text)
            {
                if (tboxnewone.Text.Length < 6)
                {
                    MessageBox.Show("密码不足6位");
                }
                else if (UserManage.UserPwdUpdate(ProgramDate.NowLoginId, userPwd))
                {
                    MessageBox.Show("修改成功");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("密码不一致");
            }
        }
    }
}
