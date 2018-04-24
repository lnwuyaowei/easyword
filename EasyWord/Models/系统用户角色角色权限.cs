using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统用户角色角色权限
    {
        public int UserGroupRightId { get; set; }
        public int UserGroupId { get; set; }
        public int UserGroupRightMenuId { get; set; }
        public string UserGroupRightMenuName { get; set; }

        public 系统用户角色 UserGroup { get; set; }
        public 系统功能权限分组明细 UserGroupRightMenu { get; set; }
    }
}
