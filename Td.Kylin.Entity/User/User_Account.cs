
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户账户
    /// </summary>
    [Table("User_Account")]
    public class User_Account : BaseEntity
    {
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID{get;set;}

        ///<summary>
        ///手机号码（唯一）
        ///</summary>
        [Column(TypeName ="varchar(11)")]
        public string Mobile{get;set;}

        ///<summary>
        ///用户名（昵称，逻辑唯一不允许修改）
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Username{get;set;}

        ///<summary>
        ///登陆密码
        ///</summary>
        [Column(TypeName = "varchar(32)")]
        public string Password{get;set;}

        /// <summary>
        /// 用户所有身份（1普通用户，2企业员工，4个人服务者，8配送员）
        /// </summary>
        public int IdentityType { get; set; }

        ///<summary>
        ///登陆次数
        ///</summary>
        public int Logins{get;set;}

        ///<summary>
        ///最后登录时间
        ///</summary>
        
        public DateTime LastTime{get;set;}
				
		///<summary>
		///用户状态（正常、封号）
		///</summary>
		public int DataStatus{get;set;}

        ///<summary>
        ///用户头像
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string UserPic{get;set;}

        /// <summary>
        /// 账户余额（不含冻结资金）
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 冻结资金
        /// </summary>
        public decimal FreezeMoney { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
        public string PaymentPassword { get; set; }

        ///<summary>
        ///注册时间
        ///</summary>
        
        public DateTime CreateTime { get; set; }

    }
}
