using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家服务型产品
    /// </summary>
    [Table("MerchService_Goods")]
    public class MerchService_Goods : BaseEntity
    {
        /// <summary>
        /// 服务产品ID
        /// </summary>
        public long ServiceGoodsID { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 所属商家的区域ID（一般为区县ID）
        /// </summary>
        public int AreaID { get; set; }

        /// <summary>
        /// 区域路径（如：110000|110100|110101）
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string AreaLayer { get; set; }

        /// <summary>
        /// 所属业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 业务类型（如：上门|预约）
        /// </summary>
        public int BusinessType { get; set; }

        /// <summary>
        /// 服务主题（服务项目名称）
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Title { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 服务说明/描述
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        /// <summary>
        /// 预约服务时的预约金，上门服务无此配置项
        /// </summary>
        public decimal SubscriptionPrice { get; set; }

        /// <summary>
        /// 销售量
        /// </summary>
        public int SaleNumber { get; set; }

        /// <summary>
        /// 总评价数
        /// </summary>
        public int EvaluateCount { get; set; }

        /// <summary>
        /// 服务商品状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
