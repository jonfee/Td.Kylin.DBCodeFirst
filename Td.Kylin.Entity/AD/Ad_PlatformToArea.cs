using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 平台广告推送到区域
    /// </summary>
    [Table("Ad_PlatformToArea")]
    public class Ad_PlatformToArea
    {
        ///<summary>
        ///广告内容ID
        ///</summary>
        [Column(TypeName = "bigint")]
        public long ContentID { get; set; }

        /// <summary>
        /// 推送到的区域ID
        /// </summary>
        public int AreaID { get; set; }

        ///<summary>
        ///归属广告位
        ///</summary>
        [Column(TypeName = "bigint")]
        public long PositionID { get; set; }

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
    }
}
