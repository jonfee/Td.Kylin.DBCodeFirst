using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Area
{
    /// <summary>
    /// 区域表
    /// </summary>
    public class System_Area
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public long AreaID { get; set; }
        /// <summary>
        /// 地区名称
        /// </summary>
        public string AreaName { get; set; }
        /// <summary>
        /// 父ID（1级为0）
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 地区级别（1为省级，2为市级，3为区、县、地级市级，4为镇，5为村、街道）
        /// </summary>
        public int AreaLevel { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
