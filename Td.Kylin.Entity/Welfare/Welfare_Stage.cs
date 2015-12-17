using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Welfare
{
    /// <summary>
    /// 商家福利发放配置
    /// </summary>
    [Table("Welfare_Config",Schema ="dbo")]
    public class Welfare_Stage
    {
        /// <summary>
        /// 发放期数ID
        /// </summary>
        public long StageID { get; set; }

        /// <summary>
        /// 是否启用（即上架）
        /// </summary>
        public bool Enabled { get; set; }
    }
}
