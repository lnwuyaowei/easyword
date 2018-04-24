using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统通知记录
    {
        public int 通知编号 { get; set; }
        public string 通知类型 { get; set; }
        public string 通知标题 { get; set; }
        public DateTime 发送时间 { get; set; }
        public string 通知内容 { get; set; }
        public bool 是否已读 { get; set; }
        public int? 发件人编号 { get; set; }
        public string 发件人姓名 { get; set; }
        public int 收件人编号 { get; set; }
        public string 收件人姓名 { get; set; }
    }
}
