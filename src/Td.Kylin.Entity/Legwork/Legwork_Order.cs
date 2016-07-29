using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 跑腿业务订单。
    /// </summary>
    [Table("Legwork_Order")]
    public class Legwork_Order : BaseEntity
    {
        /// <summary>
        /// 订单ID。
        /// </summary>
        public long OrderID
        {
            get;
            set;
        }

        /// <summary>
        /// 订单编号。
        /// </summary>
        [Column(TypeName = "nvarchar(18)")]
        public string OrderCode
        {
            get;
            set;
        }

        /// <summary>
        /// 区域ID。
        /// </summary>
        public long AreaID
        {
            get;
            set;
        }

        /// <summary>
        /// 订单类型。
        /// </summary>
        public short OrderType
        {
            get;
            set;
        }

        /// <summary>
        /// 物品分类。
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Categories
        {
            get;
            set;
        }

        /// <summary>
        /// 物品说明。
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        /// 补充说明。
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Introduction
        {
            get;
            set;
        }

        /// <summary>
        /// 物品照片。
        /// </summary>
        [Column(TypeName = "nvarchar(400)")]
        public string Pictures
        {
            get;
            set;
        }

        /// <summary>
        /// 用户要求取货地址ID。
        /// </summary>
        public long? RequiredPickAddressID
        {
            get;
            set;
        }

        /// <summary>
        /// 用户要求取货地址。
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string RequiredPickAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 用户要求取货时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RequiredPickTime
        {
            get;
            set;
        }

        /// <summary>
        /// 用户要求收货地址。
        /// </summary>
        public long RequiredDeliveryAddressID
        {
            get;
            set;
        }
        /// <summary>
        /// 用户要求收货地址。
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string RequiredDeliveryAddress
        {
            get;
            set;
        }
        /// <summary>
        /// 用户要求收货时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime RequiredDeliveryTime
        {
            get;
            set;
        }

        /// <summary>
        /// 商品金额。
        /// </summary>
        public decimal GoodsAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 服务费用。
        /// </summary>
        public decimal ServiceCharge
        {
            get;
            set;
        }

        /// <summary>
        /// 订单总额。
        /// </summary>
        public decimal ActualAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 支付方式。
        /// </summary>
        public short? PaymentMethod
        {
            get;
            set;
        }

        /// <summary>
        /// 支付类型。
        /// </summary>
        public short? PaymentType
        {
            get;
            set;
        }

        /// <summary>
        /// 订单状态。
        /// </summary>
        public short Status
        {
            get;
            set;
        }

        /// <summary>
        /// 订单提交时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime SubmitTime
        {
            get;
            set;
        }

        /// <summary>
        /// 支付时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PaymentTime
        {
            get;
            set;
        }

        /// <summary>
        /// 完成时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CompleteTime
        {
            get;
            set;
        }

        /// <summary>
        /// 取消时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CancelTime
        {
            get;
            set;
        }

        /// <summary>
        /// 接单人员ID。
        /// </summary>
        public long? WorkerID
        {
            get;
            set;
        }

        /// <summary>
        /// 采用报价ID。
        /// </summary>
        public long? OfferID
        {
            get;
            set;
        }

        /// <summary>
        /// 报价确认时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? OfferAcceptTime
        {
            get;
            set;
        }

        /// <summary>
        /// 实际取货/购买时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActualPickTime
        {
            get;
            set;
        }

        /// <summary>
        /// 实际取货/购买经度。
        /// </summary>
        public Single? ActualPickLongitude
        {
            get;
            set;
        }

        /// <summary>
        /// 实际取货/购买纬度。
        /// </summary>
        public Single? ActualPickLatitude
        {
            get;
            set;
        }

        /// <summary>
        /// 实际送达时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActualDeliveryTime
        {
            get;
            set;
        }

        /// <summary>
        /// 实际送达经度。
        /// </summary>
        public Single? ActualDeliveryLongitude
        {
            get;
            set;
        }

        /// <summary>
        /// 实际送达纬度。
        /// </summary>
        public Single? ActualDeliveryLatitude
        {
            get;
            set;
        }

        /// <summary>
        /// 评价时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EvaluateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 用户端删除。
        /// </summary>
        public bool IsDelete
        {
            get;
            set;
        }

        /// <summary>
        /// 工作端删除
        /// </summary>
        public bool IsWorkDelete { get; set; }

        /// <summary>
        /// 用户ID下单者
        /// </summary>
        public long UserID
        {
            get;
            set;
        }

        /// <summary>
        /// 获得方式，引用 LegworkOrderObtainedMethod 枚举
        /// </summary>
        public short ObtainedMethod { get; set; }
        /// <summary>
        /// 扩展数据
        /// </summary>
        [Column(TypeName = "nvarchar(MAX)")]
        public string ExtraData { get; set; }

    }
}
