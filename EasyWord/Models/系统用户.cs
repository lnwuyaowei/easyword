using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 系统用户
    {
        public int UserId { get; set; }
        public string UserLoginName { get; set; }
        public string UserTrueName { get; set; }
        public string UserPosition { get; set; }
        public string UserPassword { get; set; }
        public int BranchId { get; set; }
        public bool IsActive { get; set; }
        public bool? IsSuperMan { get; set; }
        public int? UserGroupId { get; set; }

        public 系统用户部门 Branch { get; set; }
        public 系统用户角色 UserGroup { get; set; }
    }
}
