using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家服务型产品
    /// </summary>
    [Table("MerchService_Goods", Schema = "dbo")]
    public class MerchService_Goods
    {
        /// <summary>
        /// 服务产品ID
        /// </summary>
        public long MerchantServiceID { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 所属业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 服务主题（服务项目名称）
        /// </summary>
        public long Title { get; set; }

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
        public string Description { get; set; }

        /// <summary>
        /// 预约金
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
        public DateTime CreateTime { get; set; }
    }
}
