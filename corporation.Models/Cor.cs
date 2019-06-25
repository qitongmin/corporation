using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.Models
{
    public class Cor
    {
        //社团表
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string CorName { get; set; }
        public string CreTime { get; set; }
        public int Proprieter{get;set;}
        public string PropriName { get; set; }
        public string Introduce { get; set; }
        public string TypeName { get; set; }
        public byte[] Image { get; set; }


        public Cor() { }
        public Cor(int Id, int TypeId, string CorName, string CreTime, int Proprieter, string Introduce)
        {
            this.Id = Id;
            this.TypeId = TypeId;
            this.CorName = CorName;
            this.CreTime = CreTime;
            this.Proprieter = Proprieter;
            this.Introduce = Introduce;
        }
        public Cor(int TypeId, string CorName, string CreTime, int Proprieter, string Introduce, byte[] Image)
        {
            this.TypeId = TypeId;
            this.CorName = CorName;
            this.CreTime = CreTime;
            this.Proprieter = Proprieter;
            this.Introduce = Introduce;
            this.Image = Image;
        }
        #region 社团表所有字段
        /// <summary>
        /// 社团表所有字段
        /// </summary>
        /// <param name="Id">社团id</param>
        /// <param name="TypeId">类别id</param>
        /// <param name="CorName">社团名称</param>
        /// <param name="CreTime">创建时间</param>
        /// <param name="Proprieter">社长</param>
        /// <param name="Introduce">介绍</param>
        /// <param name="Notice">公告</param>
        /// <param name="Image">LOGO</param>
        public Cor(int Id, int TypeId, string CorName, string CreTime, int Proprieter, string Introduce, byte[] Image)
        {
            this.Id = Id;
            this.TypeId = TypeId;
            this.CorName = CorName;
            this.CreTime = CreTime;
            this.Proprieter = Proprieter;
            this.Introduce = Introduce;
            this.Image = Image;
        } 
        #endregion
    }
}
