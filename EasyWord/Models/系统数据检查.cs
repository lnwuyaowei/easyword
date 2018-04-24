using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统数据检查
    {
        public int 数据检查编号 { get; set; }
        public string 数据检查名称 { get; set; }
        public string 数据检查sql { get; set; }
        public int 检查结果 { get; set; }
    }
}
