using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 岗位类型
    /// </summary>
    [Table("Job_Category",Schema ="dbo")]
    public class Job_Category : BaseEntity
    {
        /// <summary>
        /// 岗位分类ID
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public long ParentID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long OrderNo { get; set; }

        /// <summary>
        /// 总简历数
        /// </summary>
        public int ResumeCount { get; set; }

        /// <summary>
        /// 总招聘数
        /// </summary>
        public int RecruitmentCount { get; set; }

        /// <summary>
        /// 历史投递次数
        /// </summary>
        public int ApplyCount { get; set; }

        /// <summary>
        /// 标识状态集（热门）
        /// </summary>
        public int TagStatus { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime CreateTime { get; set; }

    }
}
 