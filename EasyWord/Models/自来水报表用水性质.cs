using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水报表用水性质
    {
        public string 用水性质编号 { get; set; }
        public string 用水性质名称 { get; set; }
        public decimal? 本期数吨数 { get; set; }
        public decimal? 本期数吨数占总量比例 { get; set; }
        public decimal? 本期数金额 { get; set; }
        public decimal? 本期数金额占总量比例 { get; set; }
        public decimal? 上年同期数吨数 { get; set; }
        public decimal? 上年同期数金额 { get; set; }
        public decimal? 比上年同期增减额吨数 { get; set; }
        public decimal? 比上年同期增减额金额 { get; set; }
        public decimal? 比上年同期增减比例吨数 { get; set; }
        public decimal? 比上年同期增减比例金额 { get; set; }
    }
}
