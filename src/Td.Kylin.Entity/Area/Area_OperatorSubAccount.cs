using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域运营商子账号
    /// </summary>
    [Table("Area_OperatorSubAccount")]
    public class Area_OperatorSubAccount
    {
        /// <summary>
        /// 子账号ID
        /// </summary>
        public long SubID { get; set; }

        /// <summary>
        /// 所属运营商ID
        /// </summary>
        public long OpearatorID { get; set; }

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
        /// 管理员名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string NickName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Avatar { get; set; }

        /// <summary>
        /// 角色（枚举：OperatorSubAccountRole）
        /// </summary>
        public int Role { get; set; }

        /// <summary>
        /// 账户状态（枚举：OperatorSubAccountStatus）
        /// </summary>
        public int AccountStatus { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>        
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 资料更新时间（登录时不更新）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime EditTime { get; set; }
    }
}
