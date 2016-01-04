using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台服务价格配置
    /// </summary>
    [Table("KylinService_BusinessConfig", Schema = "dbo")]
    public class KylinService_BusinessConfig
    {
        /// <summary>
        /// 所属业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 子项ID（无子项时用0表示）
        /// </summary>
        public long OptionID { get; set; }

        /// <summary>
        /// 每单位的价格
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 计价单位（枚举：小时｜月｜天｜台｜件）
        /// </summary>
        public int UnitType { get; set; }

        /// <summary>
        /// 备注/说明
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string Remark { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
