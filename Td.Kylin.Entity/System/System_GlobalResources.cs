using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统全局配置
    /// </summary>
    [Table("System_GlobalResources")]
    public class System_GlobalResources
    {
        /// <summary>
        /// 资源类型（如：摇一摇配置｜时间配置｜消息模板配置｜短信模板配置｜默认区域抽成配置）
        /// </summary>
        public int ResourceType { get; set; }

        /// <summary>
        /// 资源类型键（如：每日摇一摇次数｜B2C订单抽成｜注册时手机验证码）
        /// </summary>
        public int ResourceKey { get; set; }

        /// <summary>
        /// 键分组（如：B2C）
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Group { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }

        /// <summary>
        /// 资源值
        /// </summary>
        [Column(TypeName = "varchar(500)")]
        public string Value { get; set; }

        /// <summary>
        /// 值单位描述（例如：时间配置时1表示年，抽成配置时1表示按金额百分比）
        /// </summary>
        public int ValueUnit { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
