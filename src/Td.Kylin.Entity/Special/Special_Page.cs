using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题页
    /// </summary>
    [Table("Special_Page")]
    public class Special_Page
    {
        /// <summary>
        /// 专题页ID
        /// </summary>
        public long PageId { get; set; }

        /// <summary>
        /// 专题名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 使用模板ID
        /// </summary>
        public long TemplateId { get; set; }

        /// <summary>
        /// 模板皮肤ID（更多关联皮肤Special_TemplateSkin.SkinId）
        /// </summary>
        public long SkinId { get; set; }

        /// <summary>
        /// 专题说明/描述
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Desc { get; set; }

        /// <summary>
        /// 专题开始时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 专题结束时间（为null表示不限制）
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 浏览量
        /// </summary>
        public int Views { get; set; }

        /// <summary>
        /// 拓展数据
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string ExtendData { get; set;}

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
