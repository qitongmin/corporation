using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corporation
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void tsbtnUser_Click(object sender, EventArgs e)
        {
            //按钮颜色设置
            tsbtnUser.BackColor = SystemColors.GradientInactiveCaption;
            tsbtnCorMes.BackColor = SystemColors.Control;
            tsbtnCorType.BackColor = SystemColors.Control;
            toolStripButton1.BackColor = SystemColors.Control;

            FrmAdminUser fUser = new FrmAdminUser();
            fUser.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(fUser);
            fUser.Show();
            //设置窗体大小
            Size newSize = new Size(750, 700);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
        }

        private void tsbtnCorMes_Click(object sender, EventArgs e)
        {
            //按钮颜色设置
            tsbtnUser.BackColor = SystemColors.Control;
            tsbtnCorMes.BackColor = SystemColors.GradientInactiveCaption;
            tsbtnCorType.BackColor = SystemColors.Control;
            toolStripButton1.BackColor = SystemColors.Control;

            FrmAdminCorMes fCorMes = new FrmAdminCorMes();
            fCorMes.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(fCorMes);
            fCorMes.Show();
            //设置窗体大小
            Size newSize = new Size(900, 900);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
        }

        private void tsbtnCorType_Click(object sender, EventArgs e)
        {
            //按钮颜色设置
            tsbtnUser.BackColor = SystemColors.Control;
            tsbtnCorMes.BackColor = SystemColors.Control;
            tsbtnCorType.BackColor = SystemColors.GradientInactiveCaption;
            toolStripButton1.BackColor = SystemColors.Control;

            FrmAdminCorType fCorType=new FrmAdminCorType();
            fCorType.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(fCorType);
            fCorType.Show();
            //设置窗体大小
            Size newSize = new Size(750, 300);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            FrmAdminUser fUser = new FrmAdminUser();
            fUser.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(fUser);
            fUser.Show();
            //按钮颜色设置
            tsbtnUser.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //按钮颜色设置
            tsbtnUser.BackColor = SystemColors.Control;
            tsbtnCorMes.BackColor = SystemColors.Control;
            tsbtnCorType.BackColor = SystemColors.Control;
            toolStripButton1.BackColor = SystemColors.GradientInactiveCaption;

            FrmAdminPwd fPwd = new FrmAdminPwd();
            fPwd.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(fPwd);
            fPwd.Show();
            //设置窗体大小
            Size newSize = new Size(500, 250);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
        }
    }
}
