using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 招聘职位投递/申请
    /// </summary>
    [Table("Job_Apply")]
    public class Job_Apply : BaseEntity
    {
        /// <summary>
        /// 招聘ID
        /// </summary>
        public long RecruitmentID { get; set; }

        /// <summary>
        /// 简历ID
        /// </summary>
        public long ResumeID { get; set; }

        /// <summary>
        /// 投递状态
        /// </summary>
        public int ApplyStatus { get; set; }

        /// <summary>
        /// 商家已删除投递记录
        /// </summary>
        public bool MerchantIsDelete { get; set; }

        /// <summary>
        /// 用户已删除投递记录
        /// </summary>
        public bool UserIsDelete { get; set; }

        /// <summary>
        /// 投递/申请时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        
        public DateTime UpdateTime { get; set; }
    }
}
