using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员在企业（商家）中的业务关系
    /// </summary>
    [Table("Worker_CompanyBusiness")]
    public class Worker_CompanyBusiness : BaseEntity
    {
        /// <summary>
        /// 服务职员ID
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// 所属商家ID
        /// </summary>
        public long MerchantID { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        public long BusinessID { get; set; }
    
        /// <summary>
        /// 开始从业的年份
        /// </summary>
        public int BeginWorkYear { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 是否启用（即是否上架）
        /// </summary>
        public bool Enabled { get; set; }
        
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
