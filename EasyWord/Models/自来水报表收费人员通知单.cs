using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表收费人员通知单
    {
        public int 收费人员通知单编号 { get; set; }
        public string 通知单名称 { get; set; }
        public string 建档类型 { get; set; }
        public DateTime 收费月份 { get; set; }
        public int 收费人员编号 { get; set; }
        public string 收费人员姓名 { get; set; }
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public int 户数 { get; set; }
        public int 用水户数 { get; set; }
        public int 停用户数 { get; set; }
        public decimal 用水量 { get; set; }
        public decimal 单价 { get; set; }
        public decimal 水费 { get; set; }
        public decimal 污水费 { get; set; }
        public decimal 附加费 { get; set; }
        public decimal 其它费用 { get; set; }
        public decimal 滞纳金 { get; set; }
        public decimal 小计 { get; set; }
        public decimal 预存上次预存余额 { get; set; }
        public decimal 预存实缴金额 { get; set; }
        public decimal 预存本月预存 { get; set; }
        public decimal 预存预存余额 { get; set; }
        public decimal 合计 { get; set; }
        public int 开票数 { get; set; }
    }
}
