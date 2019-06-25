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
    public class CorService
    {
        //社团信息修改
        public static bool CorModify(Cor c)
        {
            string sqlstr = "update cor set corName=@corName,creTime=@creTime,introduce=@introduce where id="+ProgramDate.CorId;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@corName",c.CorName),
                new SqlParameter("@creTime",c.CreTime),
                new SqlParameter("@introduce",c.Introduce)
            };
            return DBHelper.ExcuteCommand(sqlstr, param);
        }
        //社团成员添加
        public static bool GetCorAdd(string xh)
        {
            string sqlstr ="update userTable set corId=@CorId where stuId=@xh";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CorId",ProgramDate.CorId),
                new SqlParameter("@xh",xh)
            };
            return DBHelper.ExcuteCommand(sqlstr,param);
        }
        //获取社团成员列表
        public static DataTable GetCorUser()
        {
            string sqlstr = "select userId as 用户ID,stuId as 学号,name as 姓名,gender as 性别,tel as 电话号码 from userTable where corId=" + ProgramDate.CorId;
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //删除社团中的团员
        public static bool RemoveUserCor(int id)
        {
            string sqlstr = "update userTable set corID=NULL where userId=" + id;
            return DBHelper.ExcuteCommand(sqlstr);
        }
        //获取社团类别列表
        public static DataTable GetCorTypeList()
        {
            string sqlstr = "select * from corType";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            return dt;
        }
        //根据社团类别id查询社团名称
        public static string GetCorTypeId(int CorTypeId)
        {
            //string sqlstr = "select typeName from corType where id="+ CorTypeId;
            //DataTable dt = DBHelper.GetDataTable(sqlstr);
            //return dt.Rows[0][0].ToString();

            string sqlstr = "select typeName from corType where id=@id";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",CorTypeId)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "未知";
            }
                
        }
    }
}
