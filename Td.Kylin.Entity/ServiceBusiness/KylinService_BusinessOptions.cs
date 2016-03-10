using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台服务业务子项
    /// </summary>
    [Table("KylinService_BusinessOptions")]
    public class KylinService_BusinessOptions : BaseEntity
    {
        /// <summary>
        /// 子项ID
        /// </summary>
        public long OptionID { get; set; }

        /// <summary>
        /// 所属业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 子项名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 备注/描述/说明
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
