using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员附属资料
    /// </summary>
    [Table("Worker_Profile")]
    public class Worker_Profile : BaseEntity
    {
        /// <summary>
        /// 服务职员ID
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

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
        /// 电话
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string JiGuan { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// 婚姻状况（枚举：如：未婚｜已婚｜离异｜丧偶等）
        /// </summary>
        public int MaritalStatus { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Column(TypeName = "varchar(18)")]
        public string CardID { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string Nation { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }

        /// <summary>
        /// 最高学历
        /// </summary>
        public int MaxEducation { get; set; }

        /// <summary>
        /// 开始参加工作年份
        /// </summary>
        public int BeginWorkYear { get; set; }

        /// <summary>
        /// 普通话程度（枚举：如：一般｜良好｜熟练｜精通）
        /// </summary>
        public int MandarinLevel { get; set; }

        /// <summary>
        /// 春节是否回家
        /// </summary>
        public bool SpringFestivalIsBack { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Intro { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
