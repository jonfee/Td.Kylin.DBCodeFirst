
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户等级规则
    /// </summary>
    [Table("System_Level")]
    public class System_Level : BaseEntity
    {
        ///<summary>
        ///数据ID
        ///</summary>
        public long LevelID { get; set; }

        ///<summary>
        ///等级名称
        ///</summary>
        [Column(TypeName = "varchar(10)")]
        public string Name { get; set; }

        ///<summary>
        ///最小积分
        ///</summary>
        public int Min { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Icon { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>
        public bool Enable { get; set; }

        ///<summary>
        ///创建时间
        ///</summary>

        public DateTime CreateTime { get; set; }

    }
}
