using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水财务营业收费情况汇总单
    {
        public string 收费情况汇总单编号 { get; set; }
        public DateTime 汇总日期 { get; set; }
        public DateTime 结帐月份 { get; set; }
        public int 汇总人员编号 { get; set; }
        public string 汇总人员姓名 { get; set; }
        public bool 销号标志 { get; set; }
        public string 用水分类 { get; set; }
        public int 实收用水量 { get; set; }
        public decimal 实收水费 { get; set; }
        public decimal 实收污水费 { get; set; }
        public decimal 实收附加费 { get; set; }
        public decimal 实收其它费用 { get; set; }
        public decimal 实收滞纳金 { get; set; }
        public decimal 实收小计 { get; set; }
        public decimal 实收本期预存 { get; set; }
        public decimal 实收合计 { get; set; }
        public int 当期用水量 { get; set; }
        public decimal 当期水费 { get; set; }
        public decimal 当期污水费 { get; set; }
        public decimal 当期附加费 { get; set; }
        public decimal 当期其它费用 { get; set; }
        public decimal 当期滞纳金 { get; set; }
        public decimal 当期小计 { get; set; }
        public decimal 当期本期预存 { get; set; }
        public decimal 当期合计 { get; set; }
        public int 陈欠用水量 { get; set; }
        public decimal 陈欠水费 { get; set; }
        public decimal 陈欠污水费 { get; set; }
        public decimal 陈欠附加费 { get; set; }
        public decimal 陈欠其它费用 { get; set; }
        public decimal 陈欠滞纳金 { get; set; }
        public decimal 陈欠小计 { get; set; }
        public decimal 陈欠本期预存 { get; set; }
        public decimal 陈欠合计 { get; set; }
    }
}
