using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域协议
    /// </summary>
    [Table("Area_Protocol")]
    public class AreaProtocol
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 协议类型（枚举：AreaProtocolType）
        /// </summary>
        public int ProtocolType { get; set; }

        /// <summary>
        /// 协议内容
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Contents { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
