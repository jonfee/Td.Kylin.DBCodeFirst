using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商品推荐表
    /// </summary>
    [Table("Mall_ProductRecommend")]
    public class Mall_ProductRecommend
    {
        /// <summary>
        /// 推荐ID-推荐页面地址枚举值
        /// </summary>
        public int RecommendID { get; set; }
        /// <summary>
        /// 关联商品ID-B2C商品ID 、 商家商品ID
        /// </summary>
        public long ProductID { get; set; }
        /// <summary>
        /// 0为B2C，1为商家
        /// </summary>
        public int WhoRecommend { get; set; }
        /// <summary>
        /// 是否推荐 true为推荐|false为不推荐
        /// </summary>
        public bool IsRecommend { get; set; }
    }
}
