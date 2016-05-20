
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 广告内容
    /// </summary>
    [Table("Ad_Content")]
    public class Ad_Content
    {
        ///<summary>
        ///广告内容ID
        ///</summary>
        [Column(TypeName = "bigint")]
        public long ContentID { get; set; }

        /// <summary>
        /// 所属区域ID
        /// </summary>
        public int AreaID { get; set; }

        ///<summary>
        ///归属广告位
        ///</summary>
        [Column(TypeName = "bigint")]
        public long PositionID { get; set; }

        ///<summary>
        ///广告数据类型（枚举：ADType）
        ///</summary>
        [Column(TypeName = "int")]
        public int ADType { get; set; }

        /// <summary>
        /// 广告数据文件
        /// </summary>
        [Column(TypeName = "nvarchar(200)")]
        public string ADFile { get; set; }

        ///<summary>
        ///广告内容标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        /// <summary>
        /// 链接类型（枚举：AdLinkType）
        /// </summary>
        public int LinkType { get; set; }

        /// <summary>
        /// 链接到的数据或地址
        /// </summary>
        public string LinkData { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>        
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
		///排序值
		///</summary>
		public int OrderNo { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
