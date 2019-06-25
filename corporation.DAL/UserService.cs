using corporation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace corporation.DAL
{
    public class UserService
    {
        #region 验证社团成员账户密码
        /// <summary>
        /// 验证社团成员账户密码
        /// </summary>
        /// <param name="u">成员</param>
        /// <returns>返回bool值，true代表有，flase代表没有 该成员</returns>
        public static bool UserLogin(User u)
        {
            string sqlstr = "select userId,stuId,corId from [userTable] where (stuId = @StuId) and (pwd = @pwd)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@stuId",u.StuId),
                new SqlParameter("@pwd",u.Pwd)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                ProgramDate.NowLoginId = int.Parse(dt.Rows[0][0].ToString());
                if (dt.Rows[0][2].ToString() !="")
                {
                    ProgramDate.CorId = int.Parse(dt.Rows[0][2].ToString());
                }
                return true;
            }
            else
                return false;
        }
        #endregion
        #region 验证社团管理员账户密码
        /// <summary>
        /// 验证社团管理员账户密码
        /// </summary>
        /// <param name="u">管理员</param>
        /// <returns>返回bool值，true代表有，flase代表没有 该成员</returns>
        public static bool CorUserLogin(User u)
        {
            string sqlstr = "select userId,id from [userTable],[cor] where (stuId = @StuId) and (pwd = @pwd) and (proprieter=userId)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@stuId",u.StuId),
                new SqlParameter("@pwd",u.Pwd)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                ProgramDate.NowLoginId = int.Parse(dt.Rows[0][0].ToString());
                if (dt.Rows[0][1].ToString() != "")
                {
                    ProgramDate.CorId = int.Parse(dt.Rows[0][1].ToString());
                }
                return true;
            }
            else
                return false;
        } 
        #endregion
        #region 验证超级管理员账户密码
        /// <summary>
        ///  验证超级管理员账户密码
        /// </summary>
        /// <param name="u">超级管理员</param>
        /// <returns>返回bool值，true代表有，flase代表没有 该成员</returns>
        public static bool AdminUserLogin(Admin u)
        {
            string sqlstr = "select adminId from [admin] where (admin = @Admin) and (adminPwd = @AdminPwd)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Admin",u.AdminName),
                new SqlParameter("@AdminPwd",u.AdminPwd)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                ProgramDate.NowAdminId = int.Parse(dt.Rows[0][0].ToString());
                return true;
            }
            else
                return false;
        }
        #endregion
        #region 用户注册
        /// <summary>
        /// 用户注册，注意重复
        /// </summary>
        /// <param name="u">用户对象</param>
        /// <returns>返回bool值,T成功，F失败</returns>
        public static bool UserRes(User u)
        {
            string sqlstr = "insert into userTable (stuId,pwd,name,tel,gender,headImg) values(@stuId,@pwd,@name,@tel,@gender,@headImg)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@stuId",u.StuId),
                new SqlParameter("@pwd",u.Pwd),
                new SqlParameter("@name",u.Name),
                new SqlParameter("@tel",u.Tel),
                new SqlParameter("@gender",u.Gender),
                new SqlParameter("@headImg",u.HeadImg)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        #endregion

        #region 获取用户个人信息
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>返回LIST,含有n个User对象</returns>
        public static List<User> GetUserList(int id)
        {
            string sqlstr = "select * from userTable where userId=" + id;
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<User> list = new List<User>();
            foreach (DataRow r in dt.Rows)
            {
                User spend = new User();
                spend.StuId = r["stuId"].ToString();
                spend.Pwd = r["pwd"].ToString();
                spend.Name = r["name"].ToString();
                spend.Tel = r["tel"].ToString();
                if (r["corId"]!=System.DBNull.Value)
                {
                    spend.CorId = int.Parse(r["corId"].ToString());
                }
                spend.Gender = r["gender"].ToString();
                spend.HeadImg = (byte[])r["headImg"];
                list.Add(spend);
            }
            return list;
        }
        #endregion
        #region 获取用户社团信息
        /// <summary>
        /// 获取用户社团信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>返回LIST,含有n个Cor对象</returns>
        public static List<Cor> GetCorList(int CorId)
        {
            string sqlstr = string.Format("select typeId,corName,creTime,proprieter,introduce from cor where cor.id={0}", CorId);
            //string sqlstr = "select corName,creTime,introduce,notice from userTable,cor where id=";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            List<Cor> list = new List<Cor>();
            foreach (DataRow r in dt.Rows)
            {
                Cor spend = new Cor();
                spend.TypeId = (int)r["typeId"];
                spend.CorName = r["corName"].ToString();
                spend.CreTime = r["creTime"].ToString();
                spend.Proprieter = int.Parse(r["proprieter"].ToString());
                spend.Introduce = r["introduce"].ToString();
                list.Add(spend);
            }
            return list;
        }
        #endregion
        //根据学号获取社团id
        public static bool GetUserCorId(string xh)
        {
            string sqlstr = "select userId,stuId,corId from [userTable] where (stuId = @xh)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@xh",xh)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0][2].ToString() != "")
                {
                    return true;
                }
            }
            return false;
        }
        //判断学号是否重复
        public static bool UserXh(string xh)
        {
            string sqlstr = "select userId,stuId,corId from [userTable] where (stuId = @StuId)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StuId",xh)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
                return true;
            else
                return false;
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
        //更新用户姓名，电话号码
        public static bool UserUpdate(User u)
        {
            string sqlstr = "update userTable set name=@Name,tel=@Tel where userId=@UserId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Name",u.Name),
                new SqlParameter("@Tel",u.Tel),
                new SqlParameter("@UserId",u.UserId)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //更新用户头像headImg
        public static bool InsertUserImg(byte[] img,int id)
        {
            string sqlstr = "update userTable set headImg=@headImg where userId=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@headImg",img),
                new SqlParameter("@id",id)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //修改用户密码
        public static bool UserPwdUpdate(int userId,string pwd)
        {
            string sqlstr = "update userTable set pwd=@pwd where userId=@userId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@pwd",pwd),
                new SqlParameter("@userId",userId)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
    }
}
