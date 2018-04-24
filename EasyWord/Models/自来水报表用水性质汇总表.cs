using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表用水性质汇总表
    {
        public int 用水性质汇总表编号 { get; set; }
        public string 报表类型 { get; set; }
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public decimal 用水量 { get; set; }
        public decimal 单价 { get; set; }
        public decimal 水费 { get; set; }
        public decimal 污水费 { get; set; }
        public decimal 附加费 { get; set; }
        public decimal 其它费用 { get; set; }
        public decimal 小计 { get; set; }
        public decimal 滞纳金 { get; set; }
        public decimal 合计 { get; set; }
        public decimal 预存余额 { get; set; }
        public decimal 本月预存 { get; set; }
        public decimal 欠费总额 { get; set; }
    }
}
