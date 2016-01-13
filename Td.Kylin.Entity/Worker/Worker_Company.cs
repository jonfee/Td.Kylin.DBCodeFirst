using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员所服务的企业（商家）
    /// </summary>
    [Table("Worker_Company", Schema = "dbo")]
    public class Worker_Company
    {
        /// <summary>
        /// 服务职员ID
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 所属商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 服务状态（即服务职员在商家下的服务状态，如：已被邀请|已拒绝|申请中|申请未通过|服务中|暂停服务|关系解除|黑名单等）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }

    }
}
