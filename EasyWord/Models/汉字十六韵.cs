using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 汉字十六韵
    {
        public string 序号 { get; set; }
        public string 押韵 { get; set; }
        public string 汉字 { get; set; }
        public int? 使用频率 { get; set; }
    }
}
