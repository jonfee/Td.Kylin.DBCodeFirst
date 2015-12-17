using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Welfare
{
    /// <summary>
    /// 赠送的商品福利信息（从）
    /// </summary>
    [Table("Welfare_DonatedGoods", Schema = "dbo")]
    public class Welfare_DonatedGoods
    {
        /// <summary>
        /// 优惠券福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string Tag { get; set; }

        /// <summary>
        /// 价值
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 领取方式
        /// </summary>
        public int DrawType { get; set; }
    }
}
