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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            dgvNoticeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //当前登录用户的id
            int id = ProgramDate.NowLoginId;
            //MessageBox.Show(id.ToString());
            //用户信息获取
            List<User> UserList =UserManage.GetUser(id);
            User u=UserList[0];

            UserlblNameCon.Text = u.Name.ToString();
            UserlblXhcon.Text = u.StuId.ToString();
            UserlblTelCon.Text = u.Tel.ToString();
            UserlblGenderCon.Text = u.Gender.ToString();
            pboxHeadImg.Image = Image.FromStream(new MemoryStream(u.HeadImg));
            pboxHeadImg.SizeMode = PictureBoxSizeMode.Zoom;

            //设置学号，性别不可用
            UserlblXhcon.Enabled = false;
            UserlblGenderCon.Enabled = false;
            //用户社团信息获取

            if (ProgramDate.CorId==-1)  //当前用户没有加入社团
            {
                pboxLOGO.Hide();
                //lblCorName.Hide();
                lblCorNameCon.Hide();
                lblCorPeo.Hide();
                lblCorPeoCon.Hide();
                lblType.Hide();
                lblTypeCon.Hide();
                lblCretime.Hide();
                lblCretimeCon.Hide();
                lblIntroduce.Hide();
                lblIntroduceCon.Hide();
                lblNotice.Hide();
                dgvNoticeList.Hide();
                lblNoticeContent.Hide();
                tboxNotice.Hide();

                lblCorName.Text = "你没有加入社团哦！";
            }
            else
            {
                //加载社团图片
                byte[] img = AdminManage.GetCorImg(ProgramDate.CorId);
                pboxLOGO.Image = Image.FromStream(new MemoryStream(img));
                pboxLOGO.SizeMode = PictureBoxSizeMode.Zoom;
                //文字信息加载
                List<Cor> CorList = UserManage.GetCor(ProgramDate.CorId);
                Cor c = CorList[0];

                lblCorNameCon.Text = c.CorName.ToString();
                lblCorPeoCon.Text = c.PropriName.ToString();   
                lblCretimeCon.Text = c.CreTime.ToString();
                lblIntroduceCon.Text = c.Introduce.ToString();
                //加载社团类别数据
                lblTypeCon.Text =CorManage.GetCorTypeId(c.TypeId);
                //加载社团公告
                DataTable dt= AdminManage.GetNoticeList(ProgramDate.CorId);
                dgvNoticeList.DataSource = dt;
                //失效设置红色
                for (int i=0;i< dt.Rows.Count;i++)
                {
                    if (DateTime.Compare(Convert.ToDateTime(dt.Rows[i][3]), DateTime.Now) < 0)
                    {
                        dgvNoticeList.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = ProgramDate.NowLoginId;
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
                    pboxHeadImg.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                    pboxHeadImg.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    MessageBox.Show("出错了！");
                }
            }
        }
        //检查电话号码是否合法
        private bool CheckTel(string tel)
        {
            return Regex.IsMatch(tel, @"^(13|14|15|16|18|19|17)\d{9}$");
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckTel(UserlblTelCon.Text))
            {
                MessageBox.Show("手机号码不合法");
                return;
            }
            User u = new User(ProgramDate.NowLoginId, UserlblNameCon.Text, UserlblTelCon.Text);
            if (UserManage.UserUpdate(u))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改成功");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPwdUpdate up = new UserPwdUpdate();
            up.Show();
        }

        private void UserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserInterface_Load(sender, e);
        }

        private void dgvNoticeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNoticeList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            //加载数据
            tboxNotice.Text = dgvNoticeList.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
