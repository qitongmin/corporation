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
    public partial class FrmAdminCorMes : Form
    {
        int id;
        int NoticeId;
        public FrmAdminCorMes()
        {
            InitializeComponent();
        }
        //加载数据
        private void FrmAdminCorMes_Load(object sender, EventArgs e)
        {
            dgvCorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCorData.DataSource = AdminManage.GetCorList();
            
        }
        //查找
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(tboxFind.Text == "")
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            DataTable dt = AdminManage.FindCorByAdmin(tboxFind.Text.Trim());
            if (dt.Rows.Count != 0)
            {
                dgvCorData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("抱歉，没有找到!");
                tboxFind.Text = "";
            }
        }
        //刷新
        private void btnNew_Click(object sender, EventArgs e)
        {
            //填充数据
            dgvCorData.DataSource = AdminManage.GetCorList();
            //加载社团公告
            dgvNotice.DataSource = AdminManage.GetNoticeList(id);
            //输入框清空
            tboxFind.Text = "";
            tboxTypeId.Text = "";
            tboxCorName.Text = "";
            tboxCreTime.Text = "";
            tboxPeo.Text = "";
            tboxIntro.Text = "";

        }
        //选择一行
        private void DGVSelect()
        {
            if (dgvCorData.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dgvCorData.SelectedRows[0].Cells[0].Value);
            //id =dgvUser.CurrentRow.Index;
        }
        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCorAdd fc = new FrmCorAdd();
            fc.Show();
        }
        //修改
        private void btnMod_Click(object sender, EventArgs e)
        {
            DGVSelect();
            if (tboxTypeId.Text.Trim() == "" || tboxCorName.Text.Trim() == "" || tboxCreTime.Text.Trim() == "" || tboxPeo.Text.Trim() == "" || tboxIntro.Text.Trim() == "" )
            {
                MessageBox.Show("信息不能为空！");
                return;
            }
            Cor c = new Cor(id,int.Parse(tboxTypeId.Text.Trim()),tboxCorName.Text.Trim(), tboxCreTime.Text, int.Parse(tboxPeo.Text.Trim()), tboxIntro.Text.Trim());
            if (AdminManage.ModCorMes(c))
            {
                MessageBox.Show("修改成功!");
                btnNew_Click(sender, e);
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
            if (AdminManage.CorDel(id))
            {
                MessageBox.Show("删除成功");
                btnNew_Click(sender, e);
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void dgvCorData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCorData.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dgvCorData.SelectedRows[0].Cells[0].Value);
            //读取数据
            tboxTypeId.Text = dgvCorData.SelectedRows[0].Cells[1].Value.ToString().Trim();
            tboxCorName.Text = dgvCorData.SelectedRows[0].Cells[2].Value.ToString().Trim();
            tboxCreTime.Text = dgvCorData.SelectedRows[0].Cells[3].Value.ToString().Trim();
            tboxPeo.Text = dgvCorData.SelectedRows[0].Cells[4].Value.ToString().Trim();
            tboxIntro.Text = dgvCorData.SelectedRows[0].Cells[5].Value.ToString().Trim();
            //加载社团图片
            byte[] img = AdminManage.GetCorImg(id);
            pictureBox1.Image = Image.FromStream(new MemoryStream(img));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //加载社团公告
            DataTable dt = AdminManage.GetNoticeList(id);
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

        private void btnHeadImg_Click(object sender, EventArgs e)
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
                    if (AdminManage.InsertCorImg(bytes,id))
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

        private void btnNoticeAdd_Click(object sender, EventArgs e)
        {
            if (tboxNoticeContent.Text.Trim()=="")
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
            string NoticeContent=tboxNoticeContent.Text;

            Notice n = new Notice(id, NoticeContent, noticeBeginDate, noticeEndDate);
            //添加公告到公告表
            if (AdminManage.AddNotice(n))
            {
                MessageBox.Show("添加成功!");
                tboxNoticeContent.Text = "";
                //加载社团公告
                DataTable dt = AdminManage.GetNoticeList(id);
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
            dtpTimeEnd.Value= Convert.ToDateTime(dgvNotice.SelectedRows[0].Cells[3].Value.ToString());
            //设置失效时间不能小于当前日期
            //dtpTimeEnd.MinDate = DateTime.Now;
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

            Notice n = new Notice(NoticeId,id, NoticeContent, noticeBeginDate, noticeEndDate);
            if (AdminManage.UpdateNotice(n))
            {
                MessageBox.Show("修改成功!");
                tboxNoticeContent.Text = "";
                //加载社团公告
                DataTable dt = AdminManage.GetNoticeList(id);
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
                DataTable dt = AdminManage.GetNoticeList(id);
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
