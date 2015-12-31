using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户福利
    /// </summary>
    [Table("User_Welfare",Schema ="dbo")]
    public class User_Welfare
    {
        /// <summary>
        /// 福利消费码
        /// </summary>
         public long ConsumerCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserID { get; set; }
        
        /// <summary>
        /// 福利ID
        /// </summary>
        public long WelfareID { get; set; }

        /// <summary>
        /// 福利类型
        /// </summary>
        public int WelfareType { get; set; }

        ///<summary>
        /// 福利提供商户ID
        ///</summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 参与抽奖时的编号
        /// </summary>
        [Column(TypeName = "varchar(12)")]
        public string PartCode { get; set; }

        ///<summary>
        /// 福利提供商户名称
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 福利名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string Tag { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Picture { get; set; }

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
        /// 是否已领取
        /// </summary>
        public bool IsAward { get; set; }

        /// <summary>
        /// 领取时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AwardTime { get; set; }

        /// <summary>
        /// 是否已使用
        /// </summary>
        public bool IsUsed { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 使用的时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UseTime { get; set; }

        /// <summary>
        /// 创建时间（获得时间）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
