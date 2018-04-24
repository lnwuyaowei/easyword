using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统信息
    {
        public int 系统编号 { get; set; }
        public string 数据库版本 { get; set; }
        public string 软件版本 { get; set; }
        public bool 日期是否取自服务器 { get; set; }
    }
}
