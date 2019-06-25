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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class FrmAdminUser : Form
    {
        int id;
        public FrmAdminUser()
        {
            InitializeComponent();
        }

        private void FrmAdminUser_Load(object sender, EventArgs e)
        {
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //填充数据
            dgvUser.DataSource = AdminManage.GetUserByAdmin();
        }
        //查找
        private void btnFind_Click(object sender, EventArgs e)
        {
            //dgvUser.DataSource = AdminManage.FindUserByAdmin(tboxFind.Text.ToString());

            if (tboxFind.Text == "")
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            DataTable dt = AdminManage.FindUserByAdmin(tboxFind.Text.ToString());
            if (dt.Rows.Count != 0)
            {
                dgvUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("抱歉，没有找到!");
                tboxFind.Text = "";
            }
        }
        //重置
        private void button5_Click(object sender, EventArgs e)
        {
            //填充数据
            dgvUser.DataSource = AdminManage.GetUserByAdmin();
            //输入框清空
            tboxXh.Text = "";
            tboxName.Text = "";
            tboxPwd.Text = "";
            cboxGender.Text = "";
            tboxTel.Text = "";
            tboxCorID.Text = "";
            //查找框清空
            tboxFind.Text = "";
        }
        //选择一行
        private void DGVSelect()
        {
            if (dgvUser.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dgvUser.SelectedRows[0].Cells[0].Value);
            //id =dgvUser.CurrentRow.Index;
        }
        //添加
        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegister ResForm = new FrmRegister(0);
            ResForm.Show();
            button5_Click(sender, e);
            //string xh = tboxXh.Text.ToString();
            //if (tboxXh.Text.Trim() == "" || tboxName.Text.Trim() == "" || tboxPwd.Text.Trim() == "" || tboxGender.Text.Trim() == "" || tboxTel.Text.Trim() == "" || tboxCorID.Text.Trim() == "")
            //{
            //    MessageBox.Show("信息不能为空！");
            //    return;
            //}
            //if (AdminManage.UserXh(xh))
            //{
            //    MessageBox.Show("学号已存在！");
            //}
            //else //添加操作
            //{
            //    User u = new User(tboxXh.Text.Trim(), tboxName.Text.Trim(), tboxPwd.Text.Trim(), tboxGender.Text.Trim(), tboxTel.Text.Trim(), int.Parse(tboxCorID.Text), id);
            //    if (AdminManage.UserAdd(u))
            //    {
            //        MessageBox.Show("添加成功");
            //        button5_Click(sender, e);
            //    }
            //    else
            //    {
            //        MessageBox.Show("添加失败");
            //    }
            //}
        }
        //修改
        private void btnMod_Click(object sender, EventArgs e)
        {
            DGVSelect();
            if (tboxXh.Text.Trim() == "" || tboxName.Text.Trim() == "" || tboxPwd.Text.Trim() == "" ||  tboxTel.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空！");
                return;
            }
            string Gender =cboxGender.Text;
            //密码md5加密
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(tboxPwd.Text.Trim());//将要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);//将字符串加密后也转换为字符数组
            string userPwd = Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为加密字符串

            User u = new User(tboxXh.Text.Trim(), tboxName.Text.Trim(), userPwd, Gender, tboxTel.Text.Trim(), int.Parse(tboxCorID.Text), id);
            if (AdminManage.ModUserMes(u))
            {
                MessageBox.Show("修改成功!");
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
        //删除
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DGVSelect();
            if (AdminManage.UserDel(id))
            {
                MessageBox.Show("删除成功");
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btnModHeadImg_Click(object sender, EventArgs e)
        {
            DGVSelect();
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请选择本地的一张图片";
            openfile.Filter = "Login图片(*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                try
                {
                    //读成二进制
                    byte[] bytes = File.ReadAllBytes(openfile.FileName);
                    if (UserManage.InsertUserImg(bytes,id))
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                        return;
                    }
                    pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    MessageBox.Show("出错了！");
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dgvUser.SelectedRows[0].Cells[0].Value);
            //读取数据
            tboxXh.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString().Trim();
            tboxPwd.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString().Trim();
            tboxName.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString().Trim();
            if (dgvUser.SelectedRows[0].Cells[4].Value.ToString().Trim() == "小帅哥")
            {
                cboxGender.SelectedIndex = 0;
            }
            else
            {
                cboxGender.SelectedIndex = 1;
            }
            tboxTel.Text = dgvUser.SelectedRows[0].Cells[5].Value.ToString().Trim();
            tboxCorID.Text = dgvUser.SelectedRows[0].Cells[6].Value.ToString().Trim();
            //加载用户头像
            byte[] img = AdminManage.GetUserImg(id);
            pictureBox1.Image = Image.FromStream(new MemoryStream(img));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
