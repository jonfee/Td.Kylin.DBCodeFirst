using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Area
{
    /// <summary>
    /// 区域运营关系表
    /// </summary>
    public class Area_Relation
    {
        /// <summary>
        /// 关系ID
        /// </summary>
        public long RelationID { get; set; }
        /// <summary>
        /// 运营商ID
        /// </summary>
        public long AreaAccountID { get; set; }
        /// <summary>
        /// 区域ID
        /// </summary>
        public long AreaID { get; set; }
        /// <summary>
        /// 运营开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 运营结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 合同号
        /// </summary>
        public string CompactNumber { get; set; }
        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LinkMan { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string Mobile { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNo { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
