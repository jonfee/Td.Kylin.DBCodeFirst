using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    ///     配送订单
    /// </summary>
    [Table("Distribution_Order")]
    public class Distribution_Order
    {
        /// <summary>
        ///     主键，订单ID
        /// </summary>
        public long OrderId
        {
            get;
            set;
        }

        /// <summary>
        ///     区域ID
        /// </summary>
        public int AreaId
        {
            get;
            set;
        }

        /// <summary>
        ///     订单编号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string OrderCode
        {
            get;
            set;
        }

        /// <summary>
        ///     配送方式，引用 Distribution_Type 枚举
        /// </summary>
        public short DistributionType
        {
            get;
            set;
        }

        /// <summary>
        ///     订单类型，引用 Distribution_OrderType 枚举
        /// </summary>
        public short OrderType
        {
            get;
            set;
        }

        /// <summary>
        ///     下单用户昵称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Nickname
        {
            get;
            set;
        }

        /// <summary>
        ///     收货联系人姓名
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Linkman
        {
            get;
            set;
        }

        /// <summary>
        ///     收货联系电话
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Telephone
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地邮编
        /// </summary>
        [Column(TypeName = "char(6)")]
        public string PostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地经度
        /// </summary>
        public Single Longitude
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地纬度
        /// </summary>
        public Single Latitude
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地区域ID路径，如：440000,440300,440301
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string RegionIds
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地区域名称路径，如：广东省,深圳市,罗湖区
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string RegionNames
        {
            get;
            set;
        }

        /// <summary>
        ///     目的地详细地址
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        ///     关联的编号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string AssociatedCode
        {
            get;
            set;
        }

        /// <summary>
        ///     订单摘要
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        ///     配送员ID
        /// </summary>
        public long? MemberId
        {
            get;
            set;
        }

        /// <summary>
        ///     订单指派时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? AssignTime
        {
            get;
            set;
        }

        /// <summary>
        ///     配送员接单时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? AcceptTime
        {
            get;
            set;
        }

        /// <summary>
        ///     配送员取货时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? PickupTime
        {
            get;
            set;
        }

        /// <summary>
        ///     配送员送达时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliveryTime
        {
            get;
            set;
        }

        /// <summary>
        ///     承运快递公司
        /// </summary>
        public long? ExpressCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     承运快递单号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ExpressOrderCode
        {
            get;
            set;
        }

        /// <summary>
        ///     订单创建时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedTime
        {
            get;
            set;
        }

        /// <summary>
        ///     订单取消时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? CancelTime
        {
            get;
            set;
        }

        /// <summary>
        ///     根据配送方式，引用 TimelyStatus 或 ExpressStatus 枚举
        /// </summary>
        public short Status
        {
            get;
            set;
        }
    }
}