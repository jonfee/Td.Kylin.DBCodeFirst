using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 配送员消息
    /// </summary>
    [Table("Distribution_MemberMessage")]
    public class Distribution_MemberMessage
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// 配送员ID，关联 User_Account 表
        /// </summary>
        public long MemberId
        {
            get;
            set;
        }


        /// <summary>
        /// 消息内容
        /// </summary>
        [Column(TypeName = "nvarchar(1000)")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>
        /// 发送时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime SendTime
        {
            get;
            set;
        }

        /// <summary>
        /// 查阅时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReceivedTime
        {
            get;
            set;
        }


    }
}
