using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统日志
    {
        public int 日志编号 { get; set; }
        public DateTime 发生日期 { get; set; }
        public int 操作人员编码 { get; set; }
        public string 操作人员姓名 { get; set; }
        public string 模块 { get; set; }
        public string 内容 { get; set; }
    }
}
