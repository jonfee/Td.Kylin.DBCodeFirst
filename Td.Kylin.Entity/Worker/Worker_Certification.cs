using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员认证信息
    /// </summary>
    [Table("Worker_Certification")]
    public class Worker_Certification : BaseEntity
    {
        ///<summary>
        /// 认证ID
        ///</summary>
        public long CertificateID { get; set; }

        ///<summary>
        /// 服务职员ID
        ///</summary>
        public long WorkerID { get; set; }

        ///<summary>
        ///认证类型（枚举：实名认证等，以2的N次方定义枚举）
        ///</summary>
        public int CertificateType { get; set; }

        ///<summary>
        ///主体名称（如：姓名等）
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        ///<summary>
        ///证件编号（如：身份证号码等）
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string CertNo { get; set; }

        ///<summary>
        ///证件照片（多个用英文逗号分隔）
        ///</summary>
        [Column(TypeName = "varchar(300)")]
        public string Pics { get; set; }

        ///<summary>
        ///审核状态（枚举：审核中，审核通过，审核失败）
        ///</summary>
        public int AuditStatus { get; set; }

        ///<summary>
        ///审核说明
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string AuditRemark { get; set; }

        ///<summary>
        ///审核时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? AuditTime { get; set; }

        ///<summary>
        ///审核的管理员ID
        ///</summary>
        public long? AuditAdminID { get; set; }

        ///<summary>
        ///审核的管理员名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string AuditAdminName { get; set; }

        ///<summary>
        ///是否被删除
        ///</summary>
        public bool IsDelete { get; set; }

        ///<summary>
        ///申请时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}
