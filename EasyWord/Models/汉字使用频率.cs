using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 汉字使用频率
    {
        public int Id { get; set; }
        public string 汉字 { get; set; }
        public int? 使用频率 { get; set; }
    }
}
