using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家优惠福利（主）
    /// </summary>
    [Table("Merchant_Welfare", Schema = "dbo")]
    public class Merchant_Welfare
    {
        /// <summary>
        /// 福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 福利类型
        /// </summary>
        public int WelfareType { get; set; }

        /// <summary>
        /// 福利名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Picture { get; set; }

        /// <summary>
        /// 发放数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 领取数量
        /// </summary>
        public int DrawNumber { get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        public int UseNumber { get; set; }

        /// <summary>
        /// 福利介绍
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Intro { get; set; }

        /// <summary>
        /// 使用/规则说明
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Regular { get; set; }

        /// <summary>
        /// 有效期（起）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ExpiryStartTime { get; set; }

        /// <summary>
        /// 有效期（止）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ExpiryEndTime { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int AuditStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
