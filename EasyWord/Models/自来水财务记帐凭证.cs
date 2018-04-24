using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水财务记帐凭证
    {
        public string 记帐凭证编号 { get; set; }
        public string 营业汇总编号 { get; set; }
        public int? 营业汇总人员编号 { get; set; }
        public string 营业汇总人员姓名 { get; set; }
        public bool? 营业汇总标志 { get; set; }
        public string 凭证类型 { get; set; }
        public DateTime 记帐日期 { get; set; }
        public DateTime 结帐月份 { get; set; }
        public int 记帐人员编号 { get; set; }
        public string 记帐人员姓名 { get; set; }
        public DateTime? 收费月份 { get; set; }
        public DateTime? 收款日期 { get; set; }
        public string 收款方式 { get; set; }
        public int 上月用水量 { get; set; }
        public int 上月表数 { get; set; }
        public int 本月表数 { get; set; }
        public int 分表数 { get; set; }
        public int 用水量 { get; set; }
        public bool? 增值税用户 { get; set; }
        public bool? 是否预存款 { get; set; }
        public string 用水性质分类 { get; set; }
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public decimal? 费率水费 { get; set; }
        public decimal? 费率污水费 { get; set; }
        public decimal? 费率附加费 { get; set; }
        public decimal? 费率其它费用 { get; set; }
        public decimal? 费率滞纳金 { get; set; }
        public decimal 应收水费 { get; set; }
        public decimal 应收污水费 { get; set; }
        public decimal 应收附加费 { get; set; }
        public decimal 应收其它费用 { get; set; }
        public decimal 应收小计 { get; set; }
        public decimal 应收滞纳金 { get; set; }
        public decimal 应收合计 { get; set; }
        public decimal 减免收费 { get; set; }
        public decimal 减免滞纳金 { get; set; }
        public decimal 应收实际应收 { get; set; }
        public decimal 实际已收 { get; set; }
        public decimal 欠费合计 { get; set; }
        public decimal 预存实缴金额 { get; set; }
        public decimal 预存本月预存 { get; set; }
        public decimal 预存上次预存余额 { get; set; }
        public decimal 预存预存余额 { get; set; }
        public int? 发票数目 { get; set; }
        public int? 抄表人员编码 { get; set; }
        public string 抄表人员姓名 { get; set; }
        public int? 收费人员编号 { get; set; }
        public string 收费人员姓名 { get; set; }
        public int? 收款人员编号 { get; set; }
        public string 收款人员姓名 { get; set; }
    }
}
