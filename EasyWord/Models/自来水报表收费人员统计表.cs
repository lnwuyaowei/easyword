using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表收费人员统计表
    {
        public int 收费人员统计表编号 { get; set; }
        public string 收费人员统计表名称 { get; set; }
        public DateTime? 时间起 { get; set; }
        public DateTime? 时间止 { get; set; }
        public int? 收费人员编号 { get; set; }
        public string 收费人员姓名 { get; set; }
        public int 户数 { get; set; }
        public int 用水户数 { get; set; }
        public decimal 用户余额 { get; set; }
        public decimal 应收用水量 { get; set; }
        public decimal 应收水费 { get; set; }
        public decimal 应收污水费 { get; set; }
        public decimal 应收附加费 { get; set; }
        public decimal 应收其它费用 { get; set; }
        public decimal 应收滞纳金 { get; set; }
        public decimal 应收减免收费 { get; set; }
        public decimal 应收减免滞纳金 { get; set; }
        public decimal 小计 { get; set; }
        public decimal 预存上次预存余额 { get; set; }
        public decimal 预存实缴金额 { get; set; }
        public decimal 预存本月预存 { get; set; }
        public decimal 预存预存余额 { get; set; }
        public decimal 合计 { get; set; }
        public decimal 开票数 { get; set; }
    }
}
