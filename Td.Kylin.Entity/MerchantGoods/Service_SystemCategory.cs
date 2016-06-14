using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.MerchantGoods
{
    /// <summary>
    /// 商家商品系统分类
    /// </summary>
    [Table("MerchantGoods_SystemCategory")]
    public class Service_SystemCategory
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 父级分类ID（顶级分类时为0）
        /// </summary>
        public long ParentCategoryID { get; set; }

        /// <summary>
        /// 分类层级路径（如：1|2|3）
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string CategoryPath { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Icon { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否已禁用
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
