using corporation.DAL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.BLL
{
    public class UserManage
    {
        //社团成员登录
        public static bool UserLogin(User u)
        {
            return UserService.UserLogin(u);
        }
        //社团管理员登录
        public static bool CorUserLogin(User u)
        {
            return UserService.CorUserLogin(u);
        }
        //超级管理员登录
        public static bool AdminUserLogin(Admin u)
        {
            return UserService.AdminUserLogin(u);
        }
        //用户注册
        public static bool UserRes(User u)
        {

            return UserService.UserRes(u);
        }
        //获取用户数据
        public static List<User> GetUser(int id)
        {
            return UserService.GetUserList(id);
        }
        //获取用户社团信息
        public static List<Cor> GetCor(int id)
        {
            List<Cor> CorList=UserService.GetCorList(id);
            Cor c = CorList[0];
            List<User> UserList=GetUser(ProgramDate.NowLoginId);
            User u = UserList[0];
            c.PropriName = u.Name.ToString();

            return CorList;
        }
        //更新用户头像
        public static bool InsertUserImg(byte[] img,int id)
        {
            return UserService.InsertUserImg(img,id);
        }
        //更新用户名字，手机号码
        public static bool UserUpdate(User u)
        {
            return UserService.UserUpdate(u);
        }
        //修改用户密码
        public static bool UserPwdUpdate(int userId,string pwd)
        {
            return UserService.UserPwdUpdate(userId,pwd);
        }
    }
}
