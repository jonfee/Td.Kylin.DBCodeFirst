using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 快递公司
    /// </summary>
    [Table("Distribution_ExpressCompany")]
    public class Distribution_ExpressCompany
    {
        /// <summary>
        /// 公司ID，主键
        /// </summary>
        public long CompanyId
        {
            get;
            set;
        }

        /// <summary>
        /// 公司编号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// 公司名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 公司图标
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Icon
        {
            get;
            set;
        }

        /// <summary>
        /// 排列顺序
        /// </summary>
        public int SortOrder
        {
            get;
            set;
        }
    }
}
