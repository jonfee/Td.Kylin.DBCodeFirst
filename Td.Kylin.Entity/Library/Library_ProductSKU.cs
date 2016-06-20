using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.Entity
{
    [Table("Library_ProductSKU")]
    public class Library_ProductSKU : BaseEntity
    {
        public long SkuID { get; set; }
        public long ProductID { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Specs { get; set; }
        public int SalesStatus { get; set; }
        public string SKU { get; set; }
        public bool IsDelete { get; set; }
    }
}
