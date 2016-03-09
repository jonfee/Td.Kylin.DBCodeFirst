using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家订单快照
    /// </summary>
    [Table("Merchant_OrderSnapshot", Schema = "dbo")]
    public class Merchant_OrderSnapshot : BaseEntity
    {
        ///<summary>
        ///快照ID
        ///</summary>
        public long SnapshotID { get; set; }
        ///<summary>
		///订单ID
		///</summary>
		public long OrderID { get; set; }
        ///<summary>
        ///商品ID
        ///</summary>
        public long GoodsID { get; set; }
        ///<summary>
		///实际成交价格
		///</summary>
		public decimal TradPrice { get; set; }
        ///<summary>
        ///购买数量
        ///</summary>
        public int BuyCounts { get; set; }
        /// <summary>
        ///  商品规格
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Specification { get; set; }

        ///<summary>
        ///商品名称
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        ///<summary>
		///市场价
		///</summary>
		public decimal MarketPrice { get; set; }

        ///<summary>
        ///销售价
        ///</summary>
        public decimal SalePrice { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Pic { get; set; }

        /// <summary>
        /// 所属自定义分类
        /// </summary>
        public long CategoryID { get; set; }

    }
}
