using corporation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.DAL
{
    public class AdminService
    {
        //获取用户列表-后台
        public static DataTable GetUserByAdmin()
        {
            string sqlstr = "select userId as 用户ID,stuId as 学号,pwd as 密码,name as 姓名,gender as 性别,tel as 电话号码,corId as 社团id from userTable";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }

        //查找用户
        public static DataTable FindUserByAdmin(string findstr)
        {
            string sqlstr = string.Format("select userId as 用户ID,stuId as 学号,pwd as 密码,name as 姓名,gender as 性别,tel as 电话号码,corId as 社团id from userTable where stuId like '%{0}%' or name like '%{1}%'", findstr,findstr);
            //string sqlstr = "select userId as 用户ID,stuId as 学号,name as 姓名,gender as 性别,tel as 电话号码,corId as 社团id from userTable where ";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //修改学生信息
        public static bool ModUserMes(User u)
        {
            string sqlstr = "update userTable set stuId=@StuId,pwd=@Pwd,name=@Name,tel=@Tel,gender=@Gender,corId=@CorId where userId=@UserId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",u.StuId),
                new SqlParameter("@Pwd",u.Pwd),
                new SqlParameter("@Name",u.Name),
                new SqlParameter("@Tel",u.Tel),
                new SqlParameter("@Gender",u.Gender),
                new SqlParameter("@CorId",u.CorId),
                new SqlParameter("@UserId",u.UserId)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //更新用户社团id
        public static bool UserCorIdUpdate(int userId,int corId)
        {
            string sqlstr = "update userTable set corId=@CorId where userId=@UserId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CorId",corId),
                new SqlParameter("@UserId",userId)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //删除学生信息
        public static bool UserDel(int id)
        {
            string sqlstr = "DELETE FROM userTable WHERE userId="+id;
            return DBHelper.ExcuteCommand(sqlstr);
        }
        //获取用户头像
        public static byte[] GetUserImg(int id)
        {
            string sqlstr = "select headImg from userTable where userId=" + id;
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return (byte[])dt.Rows[0][0];
        }
        //获取社团列表
        public static DataTable GetCorList()
        {
            string sqlstr = "select id as 社团ID,typeId as 类型id,corName as 社团名称,creTime as 创建时间,proprieter as 社长id,introduce as 社团介绍 from cor";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //获取社团 公告列表-后台dgv数据填充，参数社团id
        public static DataTable GetNoticeList(int id)
        {
            string sqlstr = "select id as 公告ID,noticeContent as 内容,noticeCreTime as 发布时间,useDate as 失效时间 from notice where noticeCorId="+id;
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //获取社团图片
        public static byte[] GetCorImg(int id)
        {
            string sqlstr = "select img from cor where id="+id;
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return (byte[])dt.Rows[0][0];
        }
        //更新社团图片Img
        public static bool InsertCorImg(byte[] img,int id)
        {
            string sqlstr = "update Cor set img=@img where id=" +id;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@img",img)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //查找社团
        public static DataTable FindCorByAdmin(string findstr)
        {
            string sqlstr = string.Format("select id as 社团ID,typeId as 类型id,corName as 社团名称,creTime as 创建时间,proprieter as 社长id,introduce as 社团介绍 from cor where corName like '%{0}%'", findstr);
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //获取最后添加的社团id
        public static int FindCorId()
        {
            string sqlstr = "select TOP 1 id from cor order by id desc";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        //删除社团
        public static bool CorDel(int id)
        {
            string sqlstr = "DELETE FROM cor WHERE id=" + id;
            return DBHelper.ExcuteCommand(sqlstr);
        }
        //修改社团信息
        public static bool ModCorMes(Cor c)
        {
            string sqlstr = "update cor set typeId = @typeId, corName = @corName, creTime = @creTime, proprieter = @proprieter, introduce =@introduce where id = @id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",c.Id),
                new SqlParameter("@typeId",c.TypeId),
                new SqlParameter("@corName",c.CorName),
                new SqlParameter("@creTime",c.CreTime),
                new SqlParameter("@proprieter",c.Proprieter),
                new SqlParameter("@introduce",c.Introduce)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //后台添加社团
        public static bool CorAdd(Cor c)
        {
            string sqlstr = "insert into cor (typeId,corName,creTime,proprieter,introduce,img) values(@typeId,@corName,@creTime,@proprieter,@introduce,@Image)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@typeId",c.TypeId),
                new SqlParameter("@corName",c.CorName),
                new SqlParameter("@creTime",c.CreTime),
                new SqlParameter("@proprieter",c.Proprieter),
                new SqlParameter("@introduce",c.Introduce),
                new SqlParameter("@Image",c.Image)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //获取社团类别列表
        public static DataTable GetCorTypeList()
        {
            string sqlstr = "select id as 类别ID,typeName as 类别名称 from corType";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //删除社团类别
        public static bool CorTypeDel(int id)
        {
            string sqlstr = "DELETE FROM corType WHERE id=" + id;
            return DBHelper.ExcuteCommand(sqlstr);
        }
        //修改社团类别
        public static bool ModCorType(CorType c)
        {
            string sqlstr = "update corType set typeName=@typeName where id=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",c.Id),
                new SqlParameter("@typeName",c.TypeName)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //添加社团类别
        public static bool AddCorType(CorType c)
        {
            string sqlstr = "insert into corType (typeName) values(@typeName)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@typeName",c.TypeName)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //获取当前超级管理员的信息
        public static string GetAdmin(int adminId)
        {
            string sqlstr = "select admin from [admin] where (adminId= @adminId)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@adminId",adminId)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);

            return dt.Rows[0][0].ToString();
        }
        //查找超级管理员账号
        public static bool findAdmin(string Admin)
        {
            string sqlstr = "select adminId from [admin] where (admin = @Admin)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Admin",Admin)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
                return false;
        }
        //修改超级管理员信息
        public static bool UpdateAdmin(int adminId, string admin, string adminPwd)
        {
            string sqlstr = "update admin set admin=@admin,adminPwd=@adminPwd where adminId=@adminId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@adminId",adminId),
                new SqlParameter("@admin",admin),
                new SqlParameter("@adminPwd",adminPwd)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //添加超级管理员---待添加-待用by2019.01.02
        public static bool AddAdmin(string admin, string adminPwd)
        {
            string sqlstr = "insert into admin (admin,adminPwd) values(@admin,@adminPwd)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@admin",admin),
                new SqlParameter("@adminPwd",adminPwd)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //添加公告列表
        public static bool AddNotice(Notice n)
        {
            string sqlstr = "insert into notice (noticeCorId,noticeContent,noticeCreTime,useDate) values(@noticeCorId,@noticeContent,@noticeCreTime,@useDate)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@noticeCorId",n.noticeCorId),
                new SqlParameter("@noticeContent",n.noticeContent),
                new SqlParameter("@noticeCreTime",n.noticeCreTime),
                new SqlParameter("@useDate",n.useDate)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //修改公告
        public static bool UpdateNotice(Notice n)
        {
            string sqlstr = "update notice set noticeCorId=@noticeCorId,noticeContent=@noticeContent,noticeCreTime=@noticeCreTime,useDate=@useDate where id=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@noticeCorId",n.noticeCorId),
                new SqlParameter("@noticeContent",n.noticeContent),
                new SqlParameter("@noticeCreTime",n.noticeCreTime),
                new SqlParameter("@useDate",n.useDate),
                new SqlParameter("@id",n.Id)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //删除公告
        public static bool DelNotice(int id)
        {
            string sqlstr = "DELETE FROM notice WHERE id=" + id;
            return DBHelper.ExcuteCommand(sqlstr);
        }
        //删除过期公告
        public static bool DelUnuseNotice()
        {
            string sqlstr = "DELETE FROM notice WHERE useDate<getdate()";
            return DBHelper.ExcuteCommand(sqlstr);
        }
    }
}
