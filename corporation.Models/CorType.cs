using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.Models
{
    public class CorType
    {
        //社团类别表
        public int Id { get; set; }
        public string TypeName { get; set; }
        public CorType(string TypeName)
        {
            this.TypeName = TypeName;
        }
        #region 社团类别表
        public CorType() { }
        /// <summary>
        /// 社团类别表
        /// </summary>
        /// <param name="Id">社团类别id</param>
        /// <param name="TypeName">类别名称</param>
        public CorType(int Id, string TypeName)
        {
            this.Id = Id;
            this.TypeName = TypeName;
        } 
        #endregion
    }
}
