using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 自定义商品分类
    /// </summary>
    [Table("MerchGoods_Category")]
    public class MerchGoods_Category : BaseEntity
    {
        /// <summary>
        /// 自定义分类ID
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 自定义分类名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        public int OrderNo { get; set;}

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }
        /// <summary>
        /// 是否服务
        /// </summary>
        public bool IsService { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
