using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 区域代理关系表
    /// </summary>
    [Table("Agent_AreaRelation")]
    public class Agent_AreaRelation : BaseEntity
    {
        /// <summary>
        /// 代理商ID
        /// </summary>
        public long AgentID { get; set; }

        /// <summary>
        /// 代理的区域ID（一般指隶属运营商区域下的下级区县ID）
        /// </summary>
        public int  AgentAreaID { get; set; }

        /// <summary>
        /// 代理开始时间
        /// </summary>        
        [Column(TypeName = "datetime")]public DateTime StartTime { get; set; }

        /// <summary>
        /// 代理结束时间
        /// </summary>        
        [Column(TypeName = "datetime")]public DateTime EndTime { get; set; }
        
        /// <summary>
        /// 备注说明
        /// </summary>
        [Column(TypeName = "nvarchar(300)")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
