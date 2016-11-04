using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题模板对应的关联组件
    /// </summary>
    [Table("Special_TemplateComponents")]
    public class Special_TemplateComponents
    {
        /// <summary>
        /// 模板组件ID
        /// </summary>
        public long TemplateComponentId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        public long TemplateId { get; set; }

        /// <summary>
        /// 组件ID
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// 组件在页面中的位置
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 组件风格ID
        /// </summary>
        public long ComponentStyleId { get; set; }

        /// <summary>
        /// 预览效果图（即组件风格效果图）
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PreviewImage { get; set; }
    }
}
