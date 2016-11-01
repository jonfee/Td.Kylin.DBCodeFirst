using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题模板
    /// </summary>
    [Table("Special_Templates")]
    public class Special_Templates
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public long TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 模板编号（如：MidAautumn001）
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Code { get; set; }

        /// <summary>
        /// 默认皮肤ID（更多关联皮肤Special_TemplateSkin.SkinId）
        /// </summary>
        public long DefaultSkinId { get; set; }

        /// <summary>
        /// 预览效果图（默认皮肤效果图）
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PreviewImage { get; set; }

        /// <summary>
        /// 模板Html
        /// </summary>
        [Column(TypeName = "text")]
        public string TemplateHtml { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public int BuyCounts { get; set; }

        /// <summary>
        /// 是否免费
        /// </summary>
        public bool IsFree { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
