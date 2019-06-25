using corporation.BLL;
using corporation.Models;
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
    public partial class FrmAdminCorType : Form
    {
        int id;
        public FrmAdminCorType()
        {
            InitializeComponent();
        }

        private void FrmAdminCorType_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = AdminManage.GetCorTypeList();
        }
        //选择一行
        private void DGVSelect()
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            //id =dgvUser.CurrentRow.Index;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tboxName.Text.Trim() == "")
            {
                MessageBox.Show("不能为空");
                return;
            }
            CorType c = new CorType(tboxName.Text.Trim());
            if (AdminManage.AddCorType(c))
            {
                MessageBox.Show("添加成功!");
                dataGridView1.DataSource = AdminManage.GetCorTypeList();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DGVSelect();
            if (AdminManage.CorTypeDel(id))
            {
                MessageBox.Show("删除成功");
                dataGridView1.DataSource = AdminManage.GetCorTypeList();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            DGVSelect();
            if (tboxName.Text.Trim() == "")
            {
                MessageBox.Show("不能为空");
                return;
            }
            CorType c = new CorType(id,tboxName.Text.Trim());
            if (AdminManage.ModCorType(c))
            {
                MessageBox.Show("修改成功!");
                dataGridView1.DataSource = AdminManage.GetCorTypeList();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行进行操作!");
                return;
            }
            id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            tboxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
        }
    }
}
