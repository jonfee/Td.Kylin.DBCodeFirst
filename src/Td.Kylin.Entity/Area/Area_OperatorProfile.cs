using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 运营商附属信息
    /// </summary>
    [Table("Area_OperatorProfile")]
    public class Area_OperatorProfile:BaseEntity
    {
        /// <summary>
        /// 运营商ID
        /// </summary>
        public long OperatorID { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [Column(TypeName = "nvarchar(11)")] 
        public string Mobile { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Photo { get; set; }
        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LinkMan { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "nvarchar(500)")]
        public string Remark { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string CompanyName { get; set; }
        /// <summary>
        /// 运营商编号
        /// </summary>
        [Column(TypeName = "nvarchar(16)")]
        public string Code { get; set; }
        /// <summary>
        /// 法人名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LegalName { get; set; }
        /// <summary>
        /// 法人身份证
        /// </summary>
        [Column(TypeName = "nvarchar(18)")]
        public string LegalIDCard { get; set; }
        ///<summary>
        ///公司地址
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string LocationPlace { get; set; }
    }
}
