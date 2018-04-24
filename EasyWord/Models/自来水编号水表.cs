using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水编号水表
    {
        public string 水表型号编号 { get; set; }
        public string 水表型号名称 { get; set; }
        public int? 水表检测周期 { get; set; }
        public string 水表最大量程 { get; set; }
        public bool 是否默认 { get; set; }
    }
}
