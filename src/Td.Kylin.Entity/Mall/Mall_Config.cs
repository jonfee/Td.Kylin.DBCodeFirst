using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 精品汇配置
    /// </summary>
    [Table("Mall_Config")]
    public class Mall_Config
    {
        /// <summary>
        /// 所属区域，主键
        /// </summary>
        public int AreaID { get; set; }
        /// <summary>
        /// 配送方式（枚举：DistributionType）
        /// </summary>
        [Obsolete("忽略，不需要此属性")]
        public int DistributionMethod { get; set; }
        /// <summary>
        /// 仓库所在经度
        /// </summary>
        public Single? WarehouseLongitude { get; set; }
        /// <summary>
        /// 仓库所在纬度
        /// </summary>
        public Single? WarehouseLatitude { get; set; }
        /// <summary>
        /// 仓库所在详细地址
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string WarehouseAddress { get; set; }
        /// <summary>
        /// 仓库电话
        /// </summary>
        [Column(TypeName = "varchar(15)")]
        public string WarehousePhone { get; set; }
        /// <summary>
        /// 普通配送预计送达时间（单位：小时）
        /// </summary>
        public int DeliveryTimeLimit { get; set; }

        /// <summary>
        /// 即时达预计送达时间（单位：分钟）
        /// </summary>
        public int InstantDeliveryMinutes { get; set; }

        /// <summary>
        /// 接受配送订单开始时间，格式：00:00:00
        /// </summary>
        [Column(TypeName = "varchar(8)")]
        public string BeginLegworkOrderTime { get; set; }

        /// <summary>
        /// 接受配送订单结束时间，格式：23:59:59
        /// </summary>
        [Column(TypeName = "varchar(8)")]
        public string EndLegworkOrderTime { get; set; }
    }
}
