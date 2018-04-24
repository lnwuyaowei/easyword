using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表用水成本
    {
        public int 成本分析编号 { get; set; }
        public DateTime 所属时期 { get; set; }
        public decimal 供水量 { get; set; }
        public decimal 售水量 { get; set; }
        public decimal 漏损水量 { get; set; }
        public decimal 应收金额 { get; set; }
        public decimal 用水比例 { get; set; }
        public decimal 平均售水单价 { get; set; }
    }
}
