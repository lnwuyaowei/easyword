using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统功能权限分组
    {
        public 系统功能权限分组()
        {
            系统功能权限分组明细 = new HashSet<系统功能权限分组明细>();
        }

        public int RighGroupId { get; set; }
        public string RightGroupName { get; set; }
        public string RightGroupDescribe { get; set; }
        public int? 排序 { get; set; }
        public bool 是否展开 { get; set; }

        public ICollection<系统功能权限分组明细> 系统功能权限分组明细 { get; set; }
    }
}
