
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 广告位
    /// </summary>
    [Table("Ad_Position", Schema = "dbo")]
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
        [Column(TypeName = "varchar"),MaxLength(10)]
        public string Code { get; set; }

        ///<summary>
        ///广告位名称
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string Name { get; set; }

        ///<summary>
        ///广告位说明
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(255)]
        public string Intro { get; set; }

        ///<summary>
        ///支持的广告类型
        ///</summary>
        [Column(TypeName = "int")]
        public int ADType { get; set; }

        ///<summary>
        ///所在广告页ID
        ///</summary>
        [Column(TypeName = "int")]
        public int PageID { get; set; }

        ///<summary>
        ///预览效果图
        ///</summary>
        [Column(TypeName = "varchar"), MaxLength(100)]
        public string PreviewPicture { get; set; }

        ///<summary>
        ///最大允许广告数
        ///</summary>
        [Column(TypeName = "int")]
        public int MaxCount { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>
        [Column(TypeName = "bit")]
        public bool Enable { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
