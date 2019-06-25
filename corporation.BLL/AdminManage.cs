using corporation.DAL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.BLL
{
    public class AdminManage
    {
        //获取用户列表-后台
        public static DataTable GetUserByAdmin()
        {
            return AdminService.GetUserByAdmin();
        }
        //查找用户
        public static DataTable FindUserByAdmin(string findstr)
        {
            return AdminService.FindUserByAdmin(findstr);
        }
        //修改用户信息
       public static bool ModUserMes(User u)
        {
            return AdminService.ModUserMes(u);
        }
        //更新用户社团id
        public static bool UserCorIdUpdate(int Userid,int corId)
        {
            return AdminService.UserCorIdUpdate(Userid, corId);
        }
        //删除学生
        public static bool UserDel(int id)
        {
            return AdminService.UserDel(id);
        }
        //查询学号是否重复
        public static bool UserXh(string xh)
        {
            return UserService.UserXh(xh);
        }
        //获取用户头像
        public static byte[] GetUserImg(int id)
        {
            return AdminService.GetUserImg(id);
        }

        //获取社团列表-后台
        public static DataTable GetCorList()
        {
            return AdminService.GetCorList();
        }
        //获取社团 公告列表-后台dgv数据填充，参数社团id
        public static DataTable GetNoticeList(int id)
        {
            return AdminService.GetNoticeList(id);
        }
        //获取社团图片
        public static byte[] GetCorImg(int id)
        {
            return AdminService.GetCorImg(id);
        }
        //插入社团图片
        public static bool InsertCorImg(byte[] img,int id)
        {
            return AdminService.InsertCorImg(img,id);
        }
        //查找社团
        public static DataTable FindCorByAdmin(string findstr)
        {
            return AdminService.FindCorByAdmin(findstr);
        }
        //获取最后添加的社团id
        public static int FindCorId()
        {
            return AdminService.FindCorId();
        }
        //修改社团信息
        public static bool ModCorMes(Cor c)
        {
            return AdminService.ModCorMes(c);
        }
        //删除社团
        public static bool CorDel(int id)
        {
            return AdminService.CorDel(id);
        }
        //社团添加
        public static bool CorAdd(Cor c)
        {
            return AdminService.CorAdd(c);
        }
        //获取社团类别列表
        public static DataTable GetCorTypeList()
        {
            return AdminService.GetCorTypeList();
        }
        //删除社团类别
        public static bool CorTypeDel(int id)
        {
            return AdminService.CorTypeDel(id);
        }
        //修改社团类别
        public static bool ModCorType(CorType c)
        {
            return AdminService.ModCorType(c);
        }
        //社团类别添加
        public static bool AddCorType(CorType c)
        {
            return AdminService.AddCorType(c);
        }
        //获取当前超级管理员的信息
        public static string GetAdmin(int adminId)
        {
            return AdminService.GetAdmin(adminId);
        }
        //查找超级管理员账号
        public static bool findAdmin(string Admin)
        {
            return AdminService.findAdmin(Admin);
        }
        //修改超级管理员信息
        public static bool UpdateAdmin(int adminId,string admin,string adminPwd)
        {
            return AdminService.UpdateAdmin(adminId, admin, adminPwd);
        }
        //添加超级管理员---待添加
        public static bool AddAdmin(string admin, string adminPwd)
        {
            return AdminService.AddAdmin(admin, adminPwd);
        }
        //添加公告
        public static bool AddNotice(Notice n)
        {
            return AdminService.AddNotice(n);
        }
        //修改公告
        public static bool UpdateNotice(Notice n)
        {
            return AdminService.UpdateNotice(n);
        }
        //删除公告
        public static bool DelNotice(int id)
        {
            return AdminService.DelNotice(id);
        }
        //删除过期公告
        public static bool DelUnuseNotice()
        {
            return AdminService.DelUnuseNotice();
        }
    }
}
