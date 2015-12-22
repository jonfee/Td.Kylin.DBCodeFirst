using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 招聘职位投递/申请
    /// </summary>
    [Table("Job_Apply",Schema ="dbo")]
    public class Job_Apply
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
        public long ApplyStatus { get; set; }

        /// <summary>
        /// 投递/申请时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
