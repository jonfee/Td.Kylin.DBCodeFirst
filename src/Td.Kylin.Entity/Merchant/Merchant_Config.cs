using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
	[Table("Merchant_Config")]
    public class Merchant_Config : BaseEntity
    {
        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }
        /// <summary>
        /// 非营业时间是否可下单
        /// </summary>
        public bool ExceedOrderTime { get; set; }
        /// <summary>
        /// 是否支持配送
        /// </summary>
        public bool IsDelivery { get; set; }
        /// <summary>
        /// 配送范围（半径范围）
        /// </summary>
        public int Scope { get; set; }
        /// <summary>
        /// 起送金额
        /// </summary>
        public decimal StartMoney { get; set; }
        /// <summary>
        /// 配送费
        /// </summary>
        public decimal DeliveryMoney { get; set; }
        /// <summary>
        /// 满多少免配送费
        /// </summary>
        public decimal ExemptDelivery { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string ExceedOrderRemark { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        [Column(TypeName = "datetime")]public DateTime UpdateTime { get; set; }
        ///<summary>
        ///营业开始时间（格式：07:30）
        ///</summary>
        [Column(TypeName = "nvarchar(10)")]
        public string BusinessBeginTime { get; set; }
        ///<summary>
        ///营业结束时间（格式：23:00）
        ///</summary>
        [Column(TypeName = "nvarchar(10)")]
        public string BusinessEndTime { get; set; }
        /// <summary>
        /// 是否在线交易
        /// </summary>
        public bool IsTransaction { get; set; }
    }
}
