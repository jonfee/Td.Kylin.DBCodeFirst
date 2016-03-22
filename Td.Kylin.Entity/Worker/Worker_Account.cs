using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员账户
    /// </summary>
    [Table("Worker_Account")]
    [Obsolete("用户账户统一后无需此模型，即将删除")]
    public class Worker_Account : BaseEntity
    {
        /// <summary>
        /// 服务职工ID
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 服务职工类型（枚举：企业员工｜独立个体）
        /// </summary>
        public int WorkerType { get; set; }

        /// <summary>
        /// 手机号（用作登录账号）
        /// </summary>
        [Column(TypeName ="varchar(11)")]
        public string Mobile { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string LoginPassword { get; set; }
        
        /// <summary>
        /// 账户余额（不含冻结资金）
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 冻结资金
        /// </summary>
        public decimal FreezeMoney { get; set; }

        /// <summary>
        /// 账户状态
        /// </summary>
        public int AccountStatus { get; set; }

        /// <summary>
        /// 抢单模式
        /// </summary>
        public int OrderMode { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        public int RegistType { get; set; }

        /// <summary>
        /// 创建时间（即注册时间）
        /// </summary>
        
        public DateTime CreateTime { get; set; }
    }
}
