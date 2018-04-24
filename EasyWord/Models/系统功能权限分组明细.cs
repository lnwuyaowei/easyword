using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统功能权限分组明细
    {
        public 系统功能权限分组明细()
        {
            系统用户角色角色权限 = new HashSet<系统用户角色角色权限>();
        }

        public int RightId { get; set; }
        public int RightGroupId { get; set; }
        public string RightName { get; set; }
        public bool IsSupper { get; set; }
        public string Picture { get; set; }

        public 系统功能权限分组 RightGroup { get; set; }
        public ICollection<系统用户角色角色权限> 系统用户角色角色权限 { get; set; }
    }
}
