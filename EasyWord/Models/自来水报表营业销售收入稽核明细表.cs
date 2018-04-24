using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表营业销售收入稽核明细表
    {
        public int 稽核明细表编号 { get; set; }
        public string 用水性质类别 { get; set; }
        public decimal 用水量 { get; set; }
        public decimal 水费 { get; set; }
        public decimal 污水费 { get; set; }
        public decimal 附加费 { get; set; }
        public decimal 其它费用 { get; set; }
        public decimal 滞纳金 { get; set; }
        public decimal 小计 { get; set; }
        public decimal 本期预存 { get; set; }
        public decimal 合计 { get; set; }
    }
}
