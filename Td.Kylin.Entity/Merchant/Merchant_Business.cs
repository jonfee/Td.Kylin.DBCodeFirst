using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家业务
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
        /// 业务状态
        /// </summary>
        public int ServiceStatus { get; set; }

        /// <summary>
        /// 审核的管理员ID
        /// </summary>
        public long AuditAdminID { get; set; }

        /// <summary>
        /// 审核的管理员名称
        /// </summary>
        public string AudtiAdminName { get; set; }

        /// <summary>
        /// 审核备注说明
        /// </summary>
        public string AuditRemark { get; set; }

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
