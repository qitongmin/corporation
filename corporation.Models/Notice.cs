using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.Models
{
    public class Notice
    {
        //公告id
        public int Id { get; set; }
        //社团id
        public int noticeCorId { get; set; }
        //公告内容
        public string noticeContent { get; set; }
        //发布时间
        public string noticeCreTime { get; set; }
        //有效期
        public string useDate { get; set; }

        public Notice() { }
        public Notice(int noticeCorId, string noticeContent, string noticeCreTime,string useDate)
        {
            this.noticeCorId = noticeCorId;
            this.noticeContent = noticeContent;
            this.noticeCreTime = noticeCreTime;
            this.useDate = useDate;
        }
        public Notice(int Id,int noticeCorId,string noticeContent,string noticeCreTime, string useDate)
        {
            this.Id = Id;
            this.noticeCorId = noticeCorId;
            this.noticeContent = noticeContent;
            this.noticeCreTime = noticeCreTime;
            this.useDate = useDate;
        }
    }
}
