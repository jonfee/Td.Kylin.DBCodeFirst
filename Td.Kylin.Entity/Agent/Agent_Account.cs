using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 代理商账户
    /// </summary>
    [Table("Agent_Account")]
    public class Agent_Account : BaseEntity
    {
        /// <summary>
        /// 代理商ID
        /// </summary>
        public long AgentID { get; set; }

        /// <summary>
        /// 代理商名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        

        /// <summary>
        /// 绑定手机号码
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string LoginPassword { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string PaymentPassword { get; set; }

        /// <summary>
        /// 所属的区域ID（指上级运营商运营的区域ID）
        /// </summary>
        public int OperatorAreaID { get; set; }

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
        public DateTime CreateTime { get; set; }
    }
}
