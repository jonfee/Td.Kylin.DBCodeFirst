using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 淘一淘商品推荐
    /// </summary>
    [Table("Tao_ProductRecommend")]
    public class Tao_ProductRecommend
    {
        /// <summary>
        /// 推荐ID
        /// </summary>
        public long RecommendID { get; set; }

        /// <summary>
        /// 所属商城类型（1为B2C区域自营，2为企业微商城）
        /// </summary>
        public int MallType { get; set; }

        /// <summary>
        /// 商品ID（B2C或商家商品）
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// 规格ID（不存在规格用0表示）
        /// </summary>
        public long SKUID { get; set; }

        /// <summary>
        /// 推荐类型
        /// </summary>
        public int RecommendType { get; set; }

        /// <summary>
        /// 开始时间（为null表示不限制）
        /// </summary>
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 结束时间（为null表示不限制）
        /// </summary>
        public DateTime? EndTime { get; set; }

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
        public DateTime UpdateTime { get; set; }
    }
}
