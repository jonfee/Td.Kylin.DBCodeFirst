using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题页组件库
    /// </summary>
    [Table("Special_Components")]
    public class Special_Components
    {
        /// <summary>
        /// 组件ID
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 编号（如：singleimage001）
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Code { get; set; }

        /// <summary>
        /// 组件类型（枚举：SpecialComponentType）
        /// </summary>
        public int ComponentType { get; set; }

        /// <summary>
        /// 组件模板HTML
        /// </summary>
        [Column(TypeName = "nvarchar(4000)")]
        public string TemplateHtml { get; set; }

        /// <summary>
        /// 预览效果图（默认风格效果图）
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PreviewImage { get; set; }

        /// <summary>
        /// 默认风格ID（更多风格关联：Special_ComponentStyle.StyleId）
        /// </summary>
        public long DefaultStyleId { get; set; }

        /// <summary>
        /// 默认配置（Json存储）
        /// </summary>
        [Column(TypeName = "nvarchar(2000)")]
        public string DefaultConfig { get; set; }

        /// <summary>
        /// 默认数据（Json存储，如：{ header:{ title:"商品组件名称"},content:[{productId:"1001",name:"商品名称"}],footer:{text:"这是底部说明文字"}}）
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string DefaultData { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
