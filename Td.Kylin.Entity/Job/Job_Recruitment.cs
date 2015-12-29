using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 招聘信息
    /// </summary>
    [Table("Job_Recruitment", Schema = "dbo")]
    public class Job_Recruitment
    {
        /// <summary>
        /// 招聘ID
        /// </summary>
        public long RecruitmentID { get; set; }

        /// <summary>
        /// 所属商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 职位类别ID
        /// </summary>
        public long CategoryID { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string JobName { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 最少提供月薪
        /// </summary>
        public int MinMonthly { get; set; }

        /// <summary>
        /// 最大提供月薪
        /// </summary>
        public int MaxMonthly { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 最小年龄限制
        /// </summary>
        public int MinAge { get; set; }

        /// <summary>
        /// 最大年龄限制
        /// </summary>
        public int MaxAge { get; set; }

        /// <summary>
        /// 学历要求
        /// </summary>
        public int MinEducation { get; set; }

        /// <summary>
        /// 工作经验要求
        /// </summary>
        public int MinJobYearsType { get; set; }

        /// <summary>
        /// 工作性质（全职|兼职）
        /// </summary>
        public int JobType { get; set; }

        /// <summary>
        /// 福利待遇（枚举：五险一金|房补等，以2的N次方定义枚举）
        /// </summary>
        public int Welfares { get; set; }

        /// <summary>
        /// 职位描述
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public int Description { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string WordAddress { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ContactMan { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string ContactPhoto { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 标识状态集（以2的N次方存储，如：推荐，置顶等）
        /// </summary>
        public int TagStatus { get; set; }

        /// <summary>
        /// 是否下架
        /// </summary>
        public bool IsUnShelve { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 浏览次数
        /// </summary>
        public int LookCount { get; set; }

        /// <summary>
        /// 投递/申请次数
        /// </summary>
        public int ApplyCount { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后刷新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastRefreshTime { get; set; }
    }
}
