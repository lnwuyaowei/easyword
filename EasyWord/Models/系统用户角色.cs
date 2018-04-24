using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统用户角色
    {
        public 系统用户角色()
        {
            系统用户 = new HashSet<系统用户>();
            系统用户角色角色权限 = new HashSet<系统用户角色角色权限>();
        }

        public int UserGroupId { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupExplanation { get; set; }

        public ICollection<系统用户> 系统用户 { get; set; }
        public ICollection<系统用户角色角色权限> 系统用户角色角色权限 { get; set; }
    }
}
