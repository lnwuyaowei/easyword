using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统用户部门
    {
        public 系统用户部门()
        {
            系统用户 = new HashSet<系统用户>();
        }

        public int 部门编号 { get; set; }
        public int? 部门父类编号 { get; set; }
        public string 部门名称 { get; set; }

        public ICollection<系统用户> 系统用户 { get; set; }
    }
}
