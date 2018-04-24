using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水缴费用户
    {
        public string 用户编号 { get; set; }
        public string 用户名称 { get; set; }
        public string 用户简码 { get; set; }
        public string 主表用户编号 { get; set; }
        public decimal 顺序号 { get; set; }
        public string 片号 { get; set; }
        public string 区号 { get; set; }
        public string 段号 { get; set; }
        public int 用水人数 { get; set; }
        public DateTime 建档日期 { get; set; }
        public string 建档类型 { get; set; }
        public DateTime 最后更新日期 { get; set; }
        public string 地址 { get; set; }
        public string 地址简码 { get; set; }
        public string 小区名称 { get; set; }
        public string 楼号 { get; set; }
        public string 单元 { get; set; }
        public string 门牌号 { get; set; }
        public string 联系电话 { get; set; }
        public string 联系手机 { get; set; }
        public string 证件类型 { get; set; }
        public string 证件号码 { get; set; }
        public string 水表型号名称 { get; set; }
        public DateTime? 水表安装日期 { get; set; }
        public string 水表安装位置 { get; set; }
        public string 用水性质分类 { get; set; }
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public string 开户银行 { get; set; }
        public string 开户银行帐号 { get; set; }
        public string 用户状态 { get; set; }
        public bool 是否倒表 { get; set; }
        public bool 增值税用户 { get; set; }
        public bool 是否预存款 { get; set; }
        public string 水表铝封号 { get; set; }
        public string 水表表号码 { get; set; }
        public string 水表表锁 { get; set; }
        public string 水表产地 { get; set; }
        public int 抄表人员编号 { get; set; }
        public string 抄表人员姓名 { get; set; }
        public int 收费人员编号 { get; set; }
        public string 收费人员姓名 { get; set; }
        public int 操作人员编号 { get; set; }
        public string 操作人员姓名 { get; set; }
        public int? 审核人员编号 { get; set; }
        public string 审核人员姓名 { get; set; }
        public string 备注 { get; set; }
        public int? Bybz { get; set; }
        public int? Sybz { get; set; }
        public int? Ysl { get; set; }
        public decimal? Syye { get; set; }
        public decimal? Ycsf { get; set; }
        public decimal? Ye { get; set; }
        public int? 初始化欠费表数 { get; set; }
    }
}
