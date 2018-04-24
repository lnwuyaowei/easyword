using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表开出水费报表
    {
        public int 开出水费报表编号 { get; set; }
        public string 时间段名称 { get; set; }
        public string 用水性质分类名称 { get; set; }
        public decimal? 售水量 { get; set; }
        public decimal? 水费 { get; set; }
        public decimal? 污水费 { get; set; }
        public decimal? 附加费 { get; set; }
        public decimal? 其它费用 { get; set; }
        public decimal? 滞纳金 { get; set; }
        public decimal? 本月预存 { get; set; }
        public decimal? 金额合计 { get; set; }
    }
}
