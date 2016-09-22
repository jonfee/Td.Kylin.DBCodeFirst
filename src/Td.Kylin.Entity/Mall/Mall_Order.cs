using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 订单
    /// </summary>
    [Table("Mall_Order")]
    public class Mall_Order : BaseEntity
    {
        ///<summary>
        ///订单ID
        ///</summary>
        public long OrderID { get; set; }

        /// <summary>
        /// 所属区域ID
        /// </summary>
        public int AreaID { get; set; }

        ///<summary>
        ///订单类型（枚举：B2COrderType）
        ///</summary>
        public int OrderType { get; set; }

        ///<summary>
        ///订单来源数据ID（如摇一摇抽中记录ID）
        ///</summary>
        public long SourceDataID { get; set; }

        ///<summary>
        ///订单编号
        ///</summary>
        [Column(TypeName = "nvarchar(18)")]
        public string OrderCode { get; set; }

        ///<summary>
        ///商品简要信息
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string ProductInfo { get; set; }

        ///<summary>
        ///合计商品金额（优惠前）
        ///</summary>
        public decimal TotalProductAmount { get; set; }

        ///<summary>
        ///合计优惠金额
        ///</summary>
        public decimal TotalDiscountAmount { get; set; }

        ///<summary>
        ///合计配送费用
        ///</summary>
        public decimal TotalDeliveryFee { get; set; }

        ///<summary>
        ///实际订单总金额（TotalProductAmount-TotalDiscountAmount+TotalDeliveryFee）
        ///</summary>
        public decimal ActualOrderAmount { get; set; }

        ///<summary>
        ///买家用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///收货信息（包括收货地址联系人电话等）
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string DeliveryInfo { get; set; }

        ///<summary>
        ///支付类型（枚举：OnlinePaymentType）
        ///</summary>
        public int PaymentType { get; set; }

        ///<summary>
        ///订单状态（枚举：B2COrderStatus）
        /// <remarks>
        /// 说明：1、订单下任意包裹发货，即视为订单已发货；
        /// </remarks>
        ///</summary>
        public int OrderStatus { get; set; }

        ///<summary>
        ///下单时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        ///<summary>
        ///支付时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? PayTime { get; set; }

        ///<summary>
        ///取消时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? CancelTime { get; set; }

        ///<summary>
        ///发货时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? ShipTime { get; set; }

        ///<summary>
        ///收货时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedTime { get; set; }

        ///<summary>
        ///评价时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? EvaluateTime { get; set; }

        ///<summary>
        ///买家已删除
        ///</summary>
        public bool IsBuyerDelete { get; set; }

        ///<summary>
        ///卖家已删除
        ///</summary>
        public bool IsVenderDelete { get; set; }

        ///<summary>
        ///必须支付的时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? NeedPayTime { get; set; }

        ///<summary>
        ///物流/配送承运公司（同城配送时为当前运营商旗下的跑腿团队）
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ExpressCompany { get; set; }

        ///<summary>
        ///物流/配送单号（同城配送时为当前订单对应的跑腿订单）
        ///</summary>
        [Column(TypeName = "nvarchar(30)")]
        public string ExpressNumber { get; set; }

        ///<summary>
        ///买家备注
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Remark { get; set; }
        /// <summary>
        /// 收货地经度
        /// </summary>
        public Single ReceivedLongitude
        {
            get;
            set;
        }

        /// <summary>
        /// 收获地纬度。
        /// </summary>
        public Single ReceivedLatitude
        {
            get;
            set;
        }

        /// <summary>
        /// 配送方式（枚举：DistributionType）
        /// </summary>
        public int DistributionType { get; set; }

        /// <summary>
        /// 订单描述说明
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string Desc { get; set; }
    }
}
