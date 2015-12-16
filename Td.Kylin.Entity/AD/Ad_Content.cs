
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 广告内容
    /// </summary>
    [Table("Ad_Content", Schema = "dbo")]
    public class Ad_Content
    {
        ///<summary>
        ///广告内容ID
        ///</summary>
        [ Column(TypeName = "bigint")]
        public long ContentID { get; set; }

        ///<summary>
        ///归属广告位
        ///</summary>
        [Column(TypeName = "bigint")]
        public long PositionID { get; set; }

        ///<summary>
        ///管理员ID
        ///</summary>
        [Column(TypeName = "bigint")]
        public long AdminID { get; set; }

        ///<summary>
        ///广告类型
        ///</summary>
        [Column(TypeName = "int")]
        public int ADType { get; set; }

        ///<summary>
        ///广告内容标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        ///<summary>
        ///广告内容
        ///</summary>
        [Column(TypeName = "nvarchar(255)")]
        public string Body { get; set; }

        ///<summary>
        ///广告链接
        ///</summary>
        [Column(TypeName = "varchar(255)")]
        public string Url { get; set; }

        ///<summary>
        ///广告HTML
        ///</summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Html { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>
        [Column(TypeName = "bit")]
        public bool Enable { get; set; }

        ///<summary>
        ///开始时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }

        ///<summary>
        ///过期时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
