﻿
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家账户信息
    /// </summary>
    [Table("Merchant_Account")]
    public class Merchant_Account : BaseEntity
    {
        ///<summary>
        ///商户ID
        ///</summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 代理商ID
        /// </summary>
        public long AgentID { get; set; }

        /// <summary>
        /// 区域ID（一般为区县ID）
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 区域路径（如：110000|110100|110101）
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string AreaLayer { get; set; }

        ///<summary>
        ///手机号码（唯一）
        ///</summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }

        ///<summary>
        ///登陆密码
        ///</summary>
        [Column(TypeName = "varchar(32)")]
        public string Password { get; set; }

        ///<summary>
        ///商户名称
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        ///<summary>
        ///所属行业ID
        ///</summary>
        public long IndustryID { get; set; }

        ///<summary>
        ///商户位置
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string LocationPlace { get; set; }

        ///<summary>
        ///街道详细地址
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Street { get; set; }

        ///<summary>
        ///纬度
        ///</summary>
        public Single Latitude { get; set; }

        ///<summary>
        ///经度
        ///</summary>
        public Single Longitude { get; set; }

        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string LinkMan { get; set; }

        ///<summary>
        ///商户电话
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }

        ///<summary>
        ///商户介绍
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        ///<summary>
        ///商户图片
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Pics { get; set; }

        /// <summary>
        /// 账户余额（不含冻结资金）
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 冻结资金
        /// </summary>
        public decimal FreezeMoney { get; set; }

        ///<summary>
        ///商户信息来源（枚举：注册商家、资料收录等）
        ///</summary>
        public int SourceType { get; set; }

        ///<summary>
        ///商家账户状态（枚举：正常，锁定等）
        ///</summary>
        public int DataStatus { get; set; }

        /// <summary>
        /// 抢单模式
        /// </summary>
        public int OrderMode { get; set; }

        ///<summary>
        ///商家认证状态（枚举：法人已认证，营业执照已认证等，以2的N次方定义枚举并累计状态值）
        ///</summary>
        public int CertificateStatus { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
        public string PayPassword { get; set; }
        /// <summary>
        /// 取现密码
        /// </summary>
        public string EncashmentPassword { get; set; }
        ///<summary>
        ///创建时间
        ///</summary>

        public DateTime CreateTime { get; set; }

    }
}
