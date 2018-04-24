using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 汉字38万词海
    {
        public int Id { get; set; }
        public string Words { get; set; }
        public string 解释 { get; set; }
        public string WordsReverse { get; set; }
        public string 押韵 { get; set; }
        public int? 押韵字使用频率 { get; set; }
    }
}
