using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域行业推荐表
    /// </summary>
    [Table("Area_RecommendIndustry")]
    public class Area_RecommendIndustry
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 行业ID
        /// </summary>
        public long IndustryID { get; set; }

        /// <summary>
        /// 行业父级ID
        /// </summary>
        public long ParentID { get; set; }    

        ///<summary>
        ///排序
        ///</summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// 推荐状态（枚举：AreaIndustryRecommend，以2的N次方值和存储）
        /// </summary>
        public int RecommendType { get; set; }
    }
}
