using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统报表
    {
        public int 报表编号 { get; set; }
        public string 报表名称 { get; set; }
        public int 行数 { get; set; }
        public int 列数 { get; set; }
        public bool 自动延深 { get; set; }
    }
}
