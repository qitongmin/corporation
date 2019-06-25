using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPwd { get; set; }

        #region 超级管理员
        public Admin() { }
        /// <summary>
        /// 超级管理员
        /// </summary>
        /// <param name="AdminName">账号</param>
        /// <param name="AdminPwd">密码</param>
        public Admin(string AdminName, string AdminPwd)
        {
            this.AdminName = AdminName;
            this.AdminPwd = AdminPwd;
        } 
        #endregion
    }
}
