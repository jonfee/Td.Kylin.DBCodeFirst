using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家推荐记录
    /// </summary>
	[Table("Merchant_RecommendRecord")]

	public class Merchant_RecommendRecord
    {
        /// <summary> 
        /// 记录ID
        /// </summary>
        public long RecordID { get; set; }

        /// <summary>
        /// 推荐目标ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 推荐业务类型(枚举)
        /// </summary>
        public int ReferrerBusinessType { get; set; }

        /// <summary>
        /// 推荐码
        /// </summary>
        [Column(TypeName = "nvarchar(6)")]
        public string RecommendCode { get; set; }
        /// <summary>
        /// 推荐人类型 （枚举：“商家或者用户”）
        /// </summary>
        public int ReferrerType
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]public DateTime CreatedTime { get; set; }
    }
}
