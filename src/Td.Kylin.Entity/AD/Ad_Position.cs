
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 广告位
    /// </summary>
    [Table("Ad_Position")]
    public class Ad_Position
    {
        ///<summary>
        ///广告位置ID
        ///</summary>
        [Column(TypeName = "bigint")]
        public long PositionID { get; set; }

        ///<summary>
        ///广告位编码
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Code { get; set; }

        ///<summary>
        ///广告位名称
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        ///<summary>
        ///广告位说明
        ///</summary>
        [Column(TypeName = "nvarchar(255)")]
        public string Intro { get; set; }

        ///<summary>
        ///广告位展示类型（枚举：ADDisplayType）
        ///</summary>
        [Column(TypeName = "int")]
        public int ADDisplayType { get; set; }

        ///<summary>
        ///所在广告页ID
        ///</summary>
        public long PageID { get; set; }

        ///<summary>
        ///预览效果图
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string PreviewPicture { get; set; }

        ///<summary>
        ///最大允许广告数
        ///</summary>
        [Column(TypeName = "int")]
        public int MaxCount { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>

        public bool Enable { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        ///   限定宽（单位：PX） 
        /// </summary>
        [Column(TypeName = "int")]
        public int LimitWidth { get; set; }

        /// <summary>
        ///   限定高（单位：PX） 
        /// </summary>
        [Column(TypeName = "int")]
        public int LimitHeight { get; set; }
        /// <summary>
        ///  排序 
        /// </summary>
        [Column(TypeName = "int")]
        public int SorderOrder { get; set; } = 0;
        /// <summary>
        /// 预览样式，后台使用
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string PreviewStyle { get; set; }

    }
}
