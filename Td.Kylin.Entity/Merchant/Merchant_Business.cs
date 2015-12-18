using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家业务关联
    /// </summary>
    [Table("Merchant_Business", Schema = "dbo")]
    public class Merchant_Business
    {
        ///<summary>
        ///商户ID
        ///</summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 服务使用状态
        /// </summary>
        public int UseStatus { get; set; }

        /// <summary>
        /// 服务开通时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? OpenServiceTime { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
