using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题模板皮肤
    /// </summary>
    [Table("Special_TemplateSkin")]
    public class Special_TemplateSkin
    {
        /// <summary>
        /// 皮肤ID
        /// </summary>
        public long SkinId { get; set; }

        /// <summary>
        /// 关联模板ID（Special_Templates.TemplateId）
        /// </summary>
        public long TemplateId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 编号（如：blue001）
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Code { get; set; }

        /// <summary>
        /// 预览效果图
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PreviewImage { get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        public int UseCounts { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
