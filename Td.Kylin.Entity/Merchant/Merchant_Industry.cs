
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家所属行业d; It doesn't matter; It will be over in the end.
    /// </summary>
    [Table("Merchant_Industry")]
    public class Merchant_Industry : BaseEntity
    {
        ///<summary>
        ///行业ID
        ///</summary>
        public long IndustryID { get; set; }

        ///<summary>
        ///行业名称
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 行业父级ID
        /// </summary>
        public long ParentID { get; set; }

        /// <summary>
        /// 行业层级（如：1｜2）
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Layer { get; set; }

        /// <summary>
        /// 标记状态集
        /// </summary>
        public int TagStatus { get; set; }

        ///<summary>
        ///排序
        ///</summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Icon { get; set; }

        ///<summary>
        ///是否禁用
        ///</summary>
        public bool Disabled { get; set; }

        ///<summary>
        ///创建时间
        ///</summary>

        public DateTime CreateTime { get; set; }

    }
}
