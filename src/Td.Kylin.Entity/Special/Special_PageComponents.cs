using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 专题页组件
    /// </summary>
    [Table("Special_PageComponents")]
    public class Special_PageComponents
    {
        /// <summary>
        /// 专题组件ID
        /// </summary>
        public long PageComponentId { get; set; }

        /// <summary>
        /// 关联专题页ID（Special_Page.PageId）
        /// </summary>
        public long PageId { get; set; }

        /// <summary>
        /// 组件在页面中的位置
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 组件ID
        /// </summary>
        public long ComponentId { get; set; }

        /// <summary>
        /// 组件类型（枚举：SpecialComponentType）
        /// </summary>
        public int ComponentType { get; set; }
        
        /// <summary>
        /// 预览效果图（即组件风格效果图）
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PreviewImage { get; set; }

        /// <summary>
        /// 风格ID（Special_ComponentStyle.StyleId）
        /// </summary>
        public long StyleId { get; set; }

        /// <summary>
        /// 配置（Json存储）
        /// </summary>
        [Column(TypeName = "nvarchar(2000)")]
        public string Config { get; set; }

        /// <summary>
        /// 数据（Json存储，如：{ header:{ title:"商品组件名称"},content:[{productId:"1001",name:"商品名称"}],footer:{text:"这是底部说明文字"}}）
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Data { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
