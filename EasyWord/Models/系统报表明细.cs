using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统报表明细
    {
        public int 报表明细编号 { get; set; }
        public int 报表编号 { get; set; }
        public string 单元格类型 { get; set; }
        public int 单元格行号 { get; set; }
        public int 单元格列号 { get; set; }
        public string 单元格内容 { get; set; }
    }
}
