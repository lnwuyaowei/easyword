using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 词库
    {
        public int 编号 { get; set; }
        public string 词名 { get; set; }
        public string 押韵 { get; set; }
        public string 词性 { get; set; }
        public string 同义词 { get; set; }
        public string 反义词 { get; set; }
        public string 发音 { get; set; }
        public string 联想 { get; set; }
        public string 时代 { get; set; }
        public string 上位词 { get; set; }
        public string 下位词 { get; set; }
        public string 情感 { get; set; }
        public string 用途 { get; set; }
    }
}
