using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 上门/预约订单
    /// </summary>
    [Table("KylinService_Order")]
    public class KylinService_Order : BaseEntity
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public long OrderID { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [Column(TypeName = "varchar(18)")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 商家ID（未抢单前为0，个人服务者抢单后为0）
        /// </summary> 
        public long MerchantID { get; set; }

        /// <summary>
        /// 服务职员ID（未抢单前为0）
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 服务者类型（枚举：商家｜个人服务者）
        /// </summary>
        public int ServerType { get; set; }

        /// <summary>
        /// 订单的业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 业务的子项ID或商家服务产品ID
        /// </summary>
        public long OptionID { get; set; }

        /// <summary>
        /// 订单业务类型（如：上门|预约）
        /// </summary>
        public int BusinessType { get; set; }

        /// <summary>
        /// 每单位的价格
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 计价单位（枚举：小时｜月｜天｜台｜件）
        /// </summary>
        public int UnitType { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ServiceStartTime { get; set; }

        /// <summary>
        /// 服务地点
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string ServiceAddress { get; set; }

        ///<summary>
		///纬度
		///</summary>
		public Single Latitude { get; set; }

        ///<summary>
        ///经度
        ///</summary>
        public Single Longitude { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户联系电话
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户备注/说明
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string UserRemark { get; set; }

        /// <summary>
        /// 服务项目内容描述
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string ServiceContent { get; set; }

        /// <summary>
        /// 服务人员备注/说明
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string WorkerRemark { get; set; }

        /// <summary>
        /// 优惠券消费码（未使用优惠券时为0表示）
        /// </summary>
        public long ConsumerCode { get; set; }

        /// <summary>
        /// 总优惠金额
        /// </summary>
        public decimal CouponAmount { get; set; }

        /// <summary>
        /// 实际订单总金额
        /// </summary>
        public decimal ActualOrderAmount { get; set; }

        /// <summary>
        /// 预支付金额
        /// </summary>
        public decimal PrepaidAmount { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public int PaymentType { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 订单取消时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CancelTime { get; set; }

        /// <summary>
        /// 商家接单时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedTime { get; set; }

        /// <summary>
        /// 派单时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AllotTime { get; set; }

        /// <summary>
        /// 订单确定时间（即双方达成一致，默认为商家接单时间）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmTime { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? PaiedTime { get; set; }

        /// <summary>
        /// 服务职员结束服务时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? WorkerFinishTime { get; set; }

        /// <summary>
        /// 用户确定服务结束时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UserFinishTime { get; set; }

        /// <summary>
        /// 用户评论时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EvaluateTime { get; set; }

        /// <summary>
        /// 用户评价等级
        /// </summary>
        public int EvaluateLevel { get; set; }

        /// <summary>
        /// 订单状态（上门/预约订单状态枚举不同）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 用户已删除
        /// </summary>
        public bool UserDelete { get; set; }

        /// <summary>
        /// 商家已删除（个人服务者订单时，为false）
        /// </summary>
        public bool MerchantDelete { get; set; }

        /// <summary>
        /// 服务职员已删除
        /// </summary>
        public bool WorkerDelete { get; set; }
    }
}
