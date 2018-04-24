using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水收费个人收费汇总单
    {
        public string 汇总编号 { get; set; }
        public DateTime 汇总日期 { get; set; }
        public int 收取现金发票张数 { get; set; }
        public decimal 收取现金汇总金额 { get; set; }
        public int 收取支票发票张数 { get; set; }
        public decimal 收取支票汇总金额 { get; set; }
        public int 发票张数 { get; set; }
        public decimal 汇总金额 { get; set; }
        public int 汇总人员编码 { get; set; }
        public string 汇总人员姓名 { get; set; }
        public int? 审核人员编码 { get; set; }
        public string 审核人员姓名 { get; set; }
        public DateTime? 审核日期 { get; set; }
        public bool 审核通过 { get; set; }
        public bool 二级汇总标志 { get; set; }
        public string 二级汇总编号 { get; set; }
        public string 备注 { get; set; }
    }
}
