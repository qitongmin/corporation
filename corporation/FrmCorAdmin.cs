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
    public partial class FrmCorAdmin : Form
    {
        int id;//社团id
        int NoticeId;
        public FrmCorAdmin()
        {
            InitializeComponent();
        }

        private void CorAdmin_Load(object sender, EventArgs e)
        {
            dgvCorUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            id = ProgramDate.CorId;
            List<Cor> CorList = UserManage.GetCor(ProgramDate.CorId);
            Cor c = CorList[0];

            tboxCorName.Text = c.CorName.ToString();
            tboxCorPeo.Text = c.PropriName.ToString();
            tboxCorCretime.Text = c.CreTime.ToString();
            tboxIntroduce.Text = c.Introduce.ToString();

            tboxCorPeo.Enabled = false;
            tboxCorType.Enabled = false;
            tboxCorCretime.Enabled = false;

            //加载社团类别数据
            tboxCorType.Text = CorManage.GetCorTypeId(c.TypeId);

            //社团用户列表加载
            dgvCorUser.DataSource = CorManage.GetCorUser();
            //加载社团公告
            
            DataTable dt= AdminManage.GetNoticeList(ProgramDate.CorId);
            dgvNotice.DataSource = dt;
            //失效设置红色
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (DateTime.Compare(Convert.ToDateTime(dt.Rows[i][3]), DateTime.Now) < 0)
                {
                    dgvNotice.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }
            }
            //禁用社团id显示
            tboxNoticeCorId.Enabled = false;
            //加载社团图片
            byte[] img = AdminManage.GetCorImg(id);
            pboxLOGO.Image = Image.FromStream(new MemoryStream(img));
            pboxLOGO.SizeMode = PictureBoxSizeMode.Zoom;
        }
        //信息清空
        private void btnReset_Click(object sender, EventArgs e)
        {
            tboxCorName.Text = "";
            tboxCorPeo.Text = "";
            tboxCorType.Text = "";
            tboxCorCretime.Text = "";
            tboxIntroduce.Text = "";
        }
        //信息修改
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tboxCorName.Text == ""|| tboxCorCretime.Text == ""|| tboxIntroduce.Text == "")
            {
                MessageBox.Show("信息不能为空!");
                return;
            }
            Cor newc = new Cor();
            newc.CorName = tboxCorName.Text;
            //newc.PropriName = tboxCorPeo.Text;
            //newc.TypeName = tboxCorType.Text;
            newc.CreTime = tboxCorCretime.Text;
            newc.Introduce = tboxIntroduce.Text;
            if (CorManage.CorModify(newc))
            {
                MessageBox.Show("修改成功");
               
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
        //加入社团成员
        private void btnCorAdd_Click(object sender, EventArgs e)
        {
            if (!AdminManage.UserXh(tboxUserXh.Text.Trim()))
            {
                MessageBox.Show("学号不存在！");
            }
            //#功能添加#还可以加入判断该同学已加入本社团或其他社团。留个坑，有空再来
            else if (CorManage.GetCorAdd(tboxUserXh.Text))
            {
                MessageBox.Show("添加成功");
                //社团用户成员表刷新
                dgvCorUser.DataSource = CorManage.GetCorUser();
                tboxUserXh.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id;
            if (dgvCorUser.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dgvCorUser.SelectedRows[0].Cells[0].Value);
            if (id == ProgramDate.NowLoginId)
            {
                MessageBox.Show("不能删除社长");
            }
            else if (CorManage.RemoveUserCor(id))
            {
                MessageBox.Show("删除成功！");
                //社团用户成员表刷新
                dgvCorUser.DataSource = CorManage.GetCorUser();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CorAdmin_Load(sender, e);
        }

        private void FrmCorAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dgvNotice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotice.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            NoticeId = Convert.ToInt16(dgvNotice.SelectedRows[0].Cells[0].Value);
            //加载数据
            tboxNoticeCorId.Text = id.ToString();
            tboxNoticeContent.Text = dgvNotice.SelectedRows[0].Cells[1].Value.ToString();
            //时间
            dtpBeginTime.Value = Convert.ToDateTime(dgvNotice.SelectedRows[0].Cells[2].Value.ToString());
            dtpTimeEnd.Value = Convert.ToDateTime(dgvNotice.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void btnNoticeAdd_Click(object sender, EventArgs e)
        {
            if (tboxNoticeContent.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空");
                return;
            }
            //获取日期
            string noticeBeginDate = dtpBeginTime.Value.ToString();
            string noticeEndDate = dtpTimeEnd.Value.ToString();
            //判断失效日期不能小于当前时间
            if (DateTime.Compare(dtpTimeEnd.Value, DateTime.Now) < 0)
            {
                MessageBox.Show("失效时间不能小于当前日期");
                return;
            }
            //获取内容
            string NoticeContent = tboxNoticeContent.Text;

            Notice n = new Notice(id, NoticeContent, noticeBeginDate, noticeEndDate);
            //添加公告到公告表
            if (AdminManage.AddNotice(n))
            {
                MessageBox.Show("添加成功!");
                //加载社团公告

                DataTable dt = AdminManage.GetNoticeList(ProgramDate.CorId);
                dgvNotice.DataSource = dt;
                //失效设置红色
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Compare(Convert.ToDateTime(dt.Rows[i][3]), DateTime.Now) < 0)
                    {
                        dgvNotice.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }
            else
            {
                MessageBox.Show("公告添加失败！");
            }
        }

        private void btnNoticeMod_Click(object sender, EventArgs e)
        {
            if (tboxNoticeContent.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空");
                return;
            }
            //获取日期
            string noticeBeginDate = dtpBeginTime.Value.ToString();
            string noticeEndDate = dtpTimeEnd.Value.ToString();
            //获取内容
            string NoticeContent = tboxNoticeContent.Text;

            Notice n = new Notice(NoticeId, id, NoticeContent, noticeBeginDate, noticeEndDate);
            if (AdminManage.UpdateNotice(n))
            {
                MessageBox.Show("修改成功!");
                tboxNoticeContent.Text = "";
                //加载社团公告

                DataTable dt = AdminManage.GetNoticeList(ProgramDate.CorId);
                dgvNotice.DataSource = dt;
                //失效设置红色
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Compare(Convert.ToDateTime(dt.Rows[i][3]), DateTime.Now) < 0)
                    {
                        dgvNotice.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }
            else
            {
                MessageBox.Show("公告修改失败！");
            }
        }

        private void btnnoticeRemove_Click(object sender, EventArgs e)
        {
            if (dgvNotice.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            NoticeId = Convert.ToInt16(dgvNotice.SelectedRows[0].Cells[0].Value);
            if (tboxNoticeContent.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空");
                return;
            }

            if (AdminManage.DelNotice(NoticeId))
            {
                MessageBox.Show("删除成功!");
                tboxNoticeContent.Text = "";
                //加载社团公告

                DataTable dt = AdminManage.GetNoticeList(ProgramDate.CorId);
                dgvNotice.DataSource = dt;
                //失效设置红色
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Compare(Convert.ToDateTime(dt.Rows[i][3]), DateTime.Now) < 0)
                    {
                        dgvNotice.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }
            else
            {
                MessageBox.Show("公告删除失败！");
            }
        }

        private void btnHeadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请选择本地的一张图片";
            openfile.Filter = "Login图片(*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                try
                {
                    //读成二进制
                    byte[] bytes = File.ReadAllBytes(openfile.FileName);
                    if (AdminManage.InsertCorImg(bytes, id))
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                        return;
                    }
                    pboxLOGO.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                    pboxLOGO.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    MessageBox.Show("出错了！");
                }
            }
        }

        private void btnDelUnuseTime_Click(object sender, EventArgs e)
        {
            if (AdminManage.DelUnuseNotice())
            {
                MessageBox.Show("删除成功!");
                tboxNoticeContent.Text = "";
                dgvNotice.DataSource = AdminManage.GetNoticeList(id);
            }
            else
            {
                MessageBox.Show("公告删除失败！");
            }
        }
    }
}
