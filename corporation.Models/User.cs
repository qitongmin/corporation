using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int CorId { get; set; }
        public string StuId { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Gender { get; set; }
        public byte[] HeadImg { get; set; }

        public User() { }
        #region 用于登录学生表-学号，密码
        /// <summary>
        /// 用于登录学生表-学号，密码
        /// </summary>
        /// <param name="StuId">学号</param>
        /// <param name="Pwd">密码</param>
        public User(string StuId, string Pwd)
        {
            this.StuId = StuId;
            this.Pwd = Pwd;
        }
        #endregion
        public User(string StuId, string Pwd, string Name, string Tel, string Gender, byte[] HeadImg)
        {
            this.StuId = StuId;
            this.Pwd = Pwd;
            this.Name = Name;
            this.Tel = Tel;
            this.Gender = Gender;
            this.HeadImg = HeadImg;
        }
        #region 用于注册的学生表
        /// <summary>
        /// 学生表的所有字段
        /// </summary>
        /// <param name="StuId">学号</param>
        /// <param name="Pwd">密码</param>
        /// <param name="Name">姓名</param>
        /// <param name="Tel">电话</param>
        /// <param name="Gender">性别</param>
        public User(int UserId, string Name, string Tel)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.Tel = Tel;

        }
        #endregion
        #region 用于后台修改信息的学生表
        public User(string StuId,string Name, string Pwd,string Gender, string Tel,int CorId,int UserId)
        {
            this.StuId = StuId;
            this.Pwd = Pwd;
            this.Name = Name;
            this.Gender = Gender;
            this.Tel = Tel;
            this.CorId = CorId;
            this.UserId = UserId;
        }
        #endregion

        #region 学生表的所有字段
        /// <summary>
        /// 学生表的所有字段
        /// </summary>
        /// <param name="UserId">id</param>
        /// <param name="CorId">社团id</param>
        /// <param name="StuId">学号</param>
        /// <param name="Pwd">密码</param>
        /// <param name="Name">姓名</param>
        /// <param name="Tel">电话</param>
        /// <param name="Gender">性别</param>
        /// <param name="HeadImg">头像</param>
        public User(int UserId, int CorId, string StuId, string Pwd, string Name, string Tel, string Gender, byte[] HeadImg)
        {
            this.UserId = UserId;
            this.CorId = CorId;
            this.StuId = StuId;
            this.Pwd = Pwd;
            this.Name = Name;
            this.Tel = Tel;
            this.Gender = Gender;
            this.HeadImg = HeadImg;
        } 
        #endregion
    }
}
