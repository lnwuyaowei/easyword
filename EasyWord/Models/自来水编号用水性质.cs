using System;
using System.Collections.Generic;

namespace EasyWord.Models
{
    public partial class 自来水编号用水性质
    {
        public 自来水编号用水性质()
        {
            自来水编号用水性质阶梯水价 = new HashSet<自来水编号用水性质阶梯水价>();
        }

        public string 用水性质编号 { get; set; }
        public string 分类名称 { get; set; }
        public string 用水性质名称 { get; set; }
        public decimal 单价 { get; set; }
        public decimal 污水费 { get; set; }
        public decimal 附加费 { get; set; }
        public decimal 其它费用 { get; set; }
        public decimal 滞纳金 { get; set; }
        public int 结帐日 { get; set; }
        public bool 阶梯水价 { get; set; }

        public ICollection<自来水编号用水性质阶梯水价> 自来水编号用水性质阶梯水价 { get; set; }
    }
}
