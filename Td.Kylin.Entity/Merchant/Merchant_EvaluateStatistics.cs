using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Merchant
{
    public class Merchant_EvaluateStatistics : BaseEntity
    {
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