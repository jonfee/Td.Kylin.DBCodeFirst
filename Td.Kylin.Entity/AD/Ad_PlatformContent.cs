using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台广告
    /// </summary>
    [Table("Ad_PlatformContent")]
    public class Ad_PlatformContent
    {
        ///<summary>
        ///广告内容ID
        ///</summary>
        [Column(TypeName = "bigint")]
        public long ContentID { get; set; }

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
        /// 链接类型（枚举：AdLinkType）
        /// </summary>
        public int LinkType { get; set; }

        /// <summary>
        /// 链接到的数据或外链地址
        /// </summary>
        public string LinkData { get; set; }

        ///<summary>
        ///广告内容标题
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Title { get; set; }

        /// <summary>
        /// 是否为全局广告内容（True表示全局，不产生任生区域关联，默认全平台统一使用）
        /// </summary>
        public bool IsGlobal { get; set; }

        ///<summary>
        ///是否启用
        ///</summary>        
        public bool Enable { get; set; }

        ///<summary>
        ///开始时间
        ///</summary>        
        public DateTime StartTime { get; set; }

        ///<summary>
        ///过期时间
        ///</summary>        
        public DateTime EndTime { get; set; }

        ///<summary>
		///排序值
		///</summary>
		public int OrderNo { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        public DateTime CreateTime { get; set; }
    }
}
