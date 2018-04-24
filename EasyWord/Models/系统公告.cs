using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统公告
    {
        public int 公告编号 { get; set; }
        public string 公告标题 { get; set; }
        public string 标题色彩 { get; set; }
        public string 公告内容 { get; set; }
        public DateTime 发布时间 { get; set; }
        public int 发布人编号 { get; set; }
        public string 发布人姓名 { get; set; }
    }
}
