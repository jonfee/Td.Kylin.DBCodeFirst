using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家服务分类
    /// </summary>
    [Table("MerchService_Category", Schema ="dbo")]
    public class MerchService_Category
    {
        ///<summary>
        /// 服务分类ID
        ///</summary>
        public long CategoryID { get; set; }

        ///<summary>
        ///服务分类名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 分类图标
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Icon { get; set; }

        ///<summary>
        ///排序
        ///</summary>
        public bool OrderNo { get; set; }

        ///<summary>
        ///是否禁用
        ///</summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        ///<summary>
        ///创建时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
