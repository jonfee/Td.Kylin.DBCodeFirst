using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家优惠福利（主）
    /// </summary>
    [Table("Merchant_Welfare")]
    public class Merchant_Welfare : BaseEntity
    {
        /// <summary>
        /// 福利ID
        /// </summary>
        public long WelfareID { get; set; }

        ///<summary>
        ///商户ID
        ///</summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        ///<summary>
        ///商户名称
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 福利类型
        /// </summary>
        public int WelfareType { get; set; }

        /// <summary>
        /// 福利名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Picture { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [Column(TypeName = "varchar(10)")]
        public string Tag { get; set; }

        /// <summary>
        /// 商家预发放数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 剩余可用数量
        /// </summary>
        public int SurplusNumber { get; set; }

        /// <summary>
        /// 总参与人数
        /// </summary>
        public int PartNumber { get; set; }

        /// <summary>
        /// 总计已中奖数量
        /// </summary>
        public int WinNumber { get; set; }

        /// <summary>
        /// 总计已领取数量
        /// </summary>
        public int DrawNumber { get; set; }

        /// <summary>
        /// 福利介绍
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Intro { get; set; }

        /// <summary>
        /// 使用/规则说明
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Regular { get; set; }

        /// <summary>
        /// 有效期（起）
        /// </summary>
        
        public DateTime ExpiryStartTime { get; set; }

        /// <summary>
        /// 有效期（止）
        /// </summary>
        
        public DateTime ExpiryEndTime { get; set; }

        /// <summary>
        /// 福利状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 审核说明
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 审核的管理员ID
        /// </summary>
        public long AuditAdminID { get; set; }

        /// <summary>
        /// 审核的管理员名称
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string AuditAdminName { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        
        public DateTime CreateTime { get; set; }
    }
}
