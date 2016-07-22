using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家评价统计
    /// </summary>
	[Table("Merchant_EvaluateStatistics")]
    public class Merchant_EvaluateStatistics : BaseEntity
    {
        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }
        ///<summary>
        ///商品ID
        ///</summary>
        public long ProductID { get; set; }

        ///<summary>
        ///评价等级
        ///</summary>
        public int EvaluateLevel { get; set; }

        ///<summary>
        ///总评价次数
        ///</summary>
        public int Counts { get; set; }
    }
}