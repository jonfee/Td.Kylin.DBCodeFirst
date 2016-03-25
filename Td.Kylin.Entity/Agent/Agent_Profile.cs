using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 代理商附属信息
    /// </summary>
    [Table("Agent_Profile")]
    public class Agent_Profile
    {
        /// <summary>
        /// 代理商ID
        /// </summary>
        public long AgentID { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string LinkMan { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string LinkPhone { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [Column(TypeName = "varchar(18)")]
        public string IDCardNo { get; set; }

        /// <summary>
        /// 身份证件正面扫描件图片地址
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string IDCardPhotoFront { get; set; }

        /// <summary>
        /// 身份证件背面扫描件图片地址
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string IDCardPhotoBack { get; set; }

        /// <summary>
        /// 营业执照扫描件图片地址
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string BusinessLicensePhoto { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remark { get; set; }
    }
}
