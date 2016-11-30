using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域配送设置
    /// </summary>
    [Table("Distribution_AreaConfig")]
    public class Distribution_AreaConfig
    {
        /// <summary>
        ///     区域ID，主键
        /// </summary>
        public int AreaId
        {
            get;
            set;
        }

        /// <summary>
        ///     普通配送预计送达时间（单位：小时）
        /// </summary>
        public int NormalExpectedDeliveryTime
        {
            get;
            set;
        }

        /// <summary>
        ///     即时达预计送达时间（单位：分钟）
        /// </summary>
        public int InstantExpectedDeliveryTime
        {
            get;
            set;
        }
    }
}