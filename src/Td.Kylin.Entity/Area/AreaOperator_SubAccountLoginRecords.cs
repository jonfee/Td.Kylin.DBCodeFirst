using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域子账号登录记录
    /// </summary>
    [Table("AreaOperator_SubAccountLoginRecords")]
    public class AreaOperator_SubAccountLoginRecords
    {
        /// <summary>
        /// 子账号ID
        /// </summary>
        public long SubID { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public  DateTime LoginTime { get; set; }

        /// <summary>
        /// 登录IP
        /// </summary>
        public  string Ip { get; set; }
    }
}
