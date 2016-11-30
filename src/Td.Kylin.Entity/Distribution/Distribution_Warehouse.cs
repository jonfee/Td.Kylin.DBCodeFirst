using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 仓库
    /// </summary>
    [Table("Distribution_Warehouse")]
    public class Distribution_Warehouse
    {
        /// <summary>
        /// 主键，仓库ID
        /// </summary>
        public long WarehouseId
        {
            get;
            set;
        }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaId
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Telephone
        {
            get;
            set;
        }

        /// <summary>
        /// 	所在经度
        /// </summary>
        public Single Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// 	所在纬度
        /// </summary>
        public Single Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// 详细地址
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 服务范围（半径）
        /// </summary>
        public int ServiceRange
        {
            get;
            set;
        }

        /// <summary>
        /// 上班时间
        /// </summary>
        [Column(TypeName = "time")]
        public DateTime OnWorkTime
        {
            get;
            set;
        }

        /// <summary>
        /// 下班时间
        /// </summary>
        [Column(TypeName = "time")]
        public DateTime OffWorkTime
        {
            get;
            set;
        }
    }
}
