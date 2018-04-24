using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统数据清除
    {
        public 系统数据清除()
        {
            系统数据清除明细 = new HashSet<系统数据清除明细>();
        }

        public int 数据清除编号 { get; set; }
        public string 分类名称 { get; set; }
        public string 名称 { get; set; }
        public string 说明 { get; set; }
        public bool 默认选择 { get; set; }

        public ICollection<系统数据清除明细> 系统数据清除明细 { get; set; }
    }
}
