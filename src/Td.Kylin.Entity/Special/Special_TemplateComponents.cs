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

        /// <summary>
        /// 默认数据（Json存储，如：{ header:{ title:"商品组件名称"},content:[{productId:"1001",name:"商品名称"}],footer:{text:"这是底部说明文字"}}）
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string DefaultData { get; set; }
    }
}
