using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 此刻推荐
    /// </summary>
    [Table("NowRecommend")]
    public class NowRecommend
    {
        /// <summary>
        /// 推荐ID
        /// </summary>
        public long RecommendID { get; set; }

        /// <summary>
        /// 数据类型（枚举值）
        /// </summary>
        public int DataType { get; set; }

        /// <summary>
        /// 数据关联ID
        /// </summary>
        public long DataID { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// B2C区域或所属商家的区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool Disabled { get; set; }
    }
}
