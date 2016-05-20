using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运营商表信息
    /// </summary>
    [Table("Area_Operator")]
    public class Area_Operator:BaseEntity
    {
        /// <summary>
        /// 运营商ID
        /// </summary> 
        public long OperatorID { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
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
        /// 创建时间
        /// </summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
