using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 淘一淘商品推荐
    /// </summary>
    [Table("Tao_ProductRecommend")]
    public class Tao_ProductRecommend
    {
        /// <summary>
        /// 所属商城类型（1为B2C区域自营，2为企业微商城）
        /// </summary>
        public int MallType { get; set; }

        /// <summary>
        /// 商品ID（B2C或商家商品）
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// 推荐标识状态集（与对应的商品标识状态同）
        /// </summary>
        public int TagTypes { get; set; }

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
