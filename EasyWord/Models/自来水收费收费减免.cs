using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水收费收费减免
    {
        public string 减免编号 { get; set; }
        public string 用户编号 { get; set; }
        public string 用户名称 { get; set; }
        public string 地址 { get; set; }
        public string 用水性质 { get; set; }
        public string 联系电话 { get; set; }
        public DateTime 申请日期 { get; set; }
        public decimal 申请减免金额 { get; set; }
        public int 收费人员编号 { get; set; }
        public string 收费人员姓名 { get; set; }
        public string 减免情况及原因 { get; set; }
        public string 营业股意见 { get; set; }
        public string 经理意见 { get; set; }
        public bool 是否审批 { get; set; }
    }
}
