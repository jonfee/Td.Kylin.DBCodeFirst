using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Area
{
    /// <summary>
    /// 运营商表信息
    /// </summary>
    public class Area_Account
    {
        /// <summary>
        /// 运营商ID
        /// </summary>
        public long AreaAccountID { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Photo { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; set; }
        /// <summary>
        /// 登录账号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string LoginPassword { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
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
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 运营商编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 法人名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        ///<summary>
        ///公司地址
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LocationPlace { get; set; }
        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LinkMan { get; set; }
        /// <summary>
        /// 创建时间（即注册时间）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
