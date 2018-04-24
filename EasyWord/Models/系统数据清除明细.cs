using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统数据清除明细
    {
        public int 数据清除明细编号 { get; set; }
        public int 数据清除编号 { get; set; }
        public string Sql { get; set; }
        public int 排序 { get; set; }

        public 系统数据清除 数据清除编号Navigation { get; set; }
    }
}
