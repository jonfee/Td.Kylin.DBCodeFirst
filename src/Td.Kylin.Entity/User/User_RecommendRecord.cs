using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户推荐记录
    /// </summary>
	[Table("User_RecommendRecord")]
    public class User_RecommendRecord
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public long RecordID { get; set; }

        /// <summary>
        /// 推荐目标ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// 推荐业务类型(枚举)
        /// </summary>
        public int ReferrerBusinessType { get; set; }

        /// <summary>
        /// 推荐码
        /// </summary>
        [Column(TypeName = "nvarchar(6)")]
        public string RecommendCode { get; set; }
        /// <summary>
        /// 推荐人类型 （枚举：“商家或者用户”）
        /// </summary>
        public int ReferrerType
        {
            get;
            set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]public DateTime CreatedTime { get; set; }

    }
}
