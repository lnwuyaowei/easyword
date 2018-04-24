using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水编号用水性质阶梯水价
    {
        public int 阶梯水价编号 { get; set; }
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public decimal 起始吨数 { get; set; }
        public decimal 终止吨数 { get; set; }
        public decimal 收费价格 { get; set; }
        public decimal 速算增加 { get; set; }

        public 自来水编号用水性质 用水性质编号Navigation { get; set; }
    }
}
