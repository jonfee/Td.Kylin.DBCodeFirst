using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运营商业务通知配置
    /// </summary>
    [Table("AreaOperator_BusinessNoticeConfig")]
    public class AreaOperator_BusinessNoticeConfig
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        public long ConfigID { get; set; }

        /// <summary>
        /// 所属运营商ID
        /// </summary>
        public long OpearatorID { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        public long SubID { get; set; }

        /// <summary>
        /// 业务通知类型（枚举：OperatorBusinessNoticeType，如：发货通知|库存预警等）
        /// </summary>
        public int NoticeType { get; set; }

        /// <summary>
        /// 业务通知途径（枚举：OperatorBusinessNoticeWay,多个通知途径用枚举值累加方式，如：手机短信1+邮箱2=3）
        /// </summary>
        public int NoticeWay { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
    }
}
