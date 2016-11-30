using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户令牌
    /// </summary>
    [Table("Token_User")]
    public class Token_User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        [Column(TypeName ="char(32)")]
        public string Token { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// 客户端类型
        /// </summary>
        public int Client { get; set; }

        /// <summary>
        /// 令牌生成时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 令牌失效时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ExpiryTime { get; set; }
    }
}
