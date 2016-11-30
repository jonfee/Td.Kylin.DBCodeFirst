using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Distribution
{
    /// <summary>
    ///  配送员所属仓库
    /// </summary>
    [Table("Distribution_MemberWarehouseRelation")]
    public class Distribution_MemberWarehouseRelation
    {
        /// <summary>
        /// 主键，关联 Distribution_Member 表
        /// </summary>
        public long MemberId
        {
            get;
            set;
        }

        /// <summary>
        /// 主键，关联 Distribution_Warehouse 表
        /// </summary>
        public long WarehouseId
        {
            get;
            set;
        }
    }
}
