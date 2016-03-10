using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户简历
    /// </summary>
    [Table("User_Resume")]
    public class User_Resume : BaseEntity
    {
        /// <summary>
        /// 简历ID
        /// </summary>
        public long ResumeID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column(TypeName ="nvarchar(20)")]
        public string RealName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Photo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime Both { get; set; }

        /// <summary>
        /// 最高学历
        /// </summary>
        public int MaxEducation { get; set; }

        /// <summary>
        /// 工作经验
        /// </summary>
        public int JobYearsType { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string ContactPhoto { get; set; }

        /// <summary>
        /// 意向工作区域
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string WantWordArea { get; set; }

        /// <summary>
        /// 职位类别ID
        /// </summary>
        public long CategoryID { get; set;}

        /// <summary>
        /// 职位名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string JobName { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        public int HopeSalary { get; set; }

        /// <summary>
        /// 到岗时间
        /// </summary>
        public int JoinTime { get; set; }

        /// <summary>
        /// 自我评述
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Intro { get; set; }

        /// <summary>
        /// 简历查看次数
        /// </summary>
        public int LookCount { get; set; }

        /// <summary>
        /// 投递/申请次数
        /// </summary>
        public int ApplyCount { get; set; }

        /// <summary>
        /// 简历状态
        /// </summary>
        public int ResumeStatus { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 最后刷新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastRefreshTime { get; set; }
    }
}
