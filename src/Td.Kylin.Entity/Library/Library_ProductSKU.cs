using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 产品库SKU
    /// </summary>
    [Table("Library_ProductSKU")]
    public class Library_ProductSKU : BaseEntity
    {
        /// <summary>
        /// SKUID
        /// </summary>
        public long SkuID { get; set; }

        /// <summary>
        /// 所属产品ID
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// 市场参考价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 销售参考价
        /// </summary>
        public decimal SalePrice { get; set; }
        
        /// <summary>
        /// 规格名称
        /// </summary>
        public string Specs { get; set; }

        /// <summary>
        /// 销售状态
        /// </summary>
        public int SalesStatus { get; set; }

        /// <summary>
        /// SKU编码
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
