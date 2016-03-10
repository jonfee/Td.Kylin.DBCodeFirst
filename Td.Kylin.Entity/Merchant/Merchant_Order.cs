using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家订单表
    /// </summary>
    [Table("Merchant_Order")]
    public class Merchant_Order : BaseEntity
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [Column(TypeName ="varchar(18)")]
        public string OrderCode { get; set; }
        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchatID { get; set; }
        /// <summary>
        /// 优惠券ID 
        /// </summary>
        public long WelfareID { get; set; }
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
        /// <summary>
        /// 配送方式（商家配送、用户自提）
        /// </summary>
        public int DeliveryMode { get; set; }
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
        ///支付类型
        ///</summary>
        public int PaymentType { get; set; }

        ///<summary>
        ///订单状态
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
        /// <summary>
        /// 发货时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? SendTime { get; set; }
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
        /// <summary>
        /// 发货说明
        /// </summary>
        [Column(TypeName = "varchar(100)")]

        public string SendRemark { get; set; }
        ///<summary>
        ///买家已删除
        ///</summary>
        public bool IsBuyerDelete { get; set; }

        ///<summary>
        ///卖家已删除
        ///</summary>
        public bool IsVenderDelete { get; set; }
        ///<summary>
        ///买家备注
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Remark { get; set; }


    }
}
