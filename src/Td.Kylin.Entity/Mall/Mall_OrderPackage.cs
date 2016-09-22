using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商城订单包裹
    /// </summary>
    [Table("Mall_OrderPackage")]
    public class Mall_OrderPackage
    {
        /// <summary>
        /// 包裹Id
        /// </summary>
        public long PackageId { get; set; }

        /// <summary>
        /// 所属订单Id
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 包裹编号
        /// </summary>
        public int PackageNo { get; set; }

        /// <summary>
        /// 当前包裹中的商品快照Id集合（多个用英文逗号分隔）
        /// </summary>
        public string SnapshotIDs { get; set; }

        ///<summary>
        ///合计商品金额（优惠前）
        ///</summary>
        public decimal TotalProductAmount { get; set; }

        ///<summary>
        ///合计配送费用
        ///</summary>
        public decimal TotalDeliveryFee { get; set; }

        /// <summary>
        /// 配送方式（枚举：DistributionType）
        /// </summary>
        public int DistributionType { get; set; }

        ///<summary>
        ///物流/配送承运公司（同城配送时为当前运营商旗下的跑腿团队）
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ExpressCompany { get; set; }

        ///<summary>
        ///物流/配送单号（同城配送时为当前订单对应的跑腿订单订单编号）
        ///</summary>
        [Column(TypeName = "nvarchar(30)")]
        public string ExpressNumber { get; set; }

        /// <summary>
        /// 快递/配送时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ExpressTime { get; set; }

        /// <summary>
        /// 描述说明（拓展属性）
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Desc { get; set; }
    }
}
