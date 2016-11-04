using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题组件风格
    /// </summary>
    [Table("Special_ComponentStyle")]
    public class Special_ComponentStyle
    {
        /// <summary>
        /// 风格ID
        /// </summary>
        public long StyleId { get; set; }

        /// <summary>
        /// 关联的组件ID（Special_Components.ComponentId）
        /// </summary>
        public long ComponentId { get; set; }

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
        /// 样式内容
        /// </summary>
        [Column(TypeName = "varchar(4000)")]
        public string StyleText { get; set; }

        /// <summary>
        /// 风格规则(JSON,如：约定图片的尺寸等）
        /// </summary>
        public string Rules { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
