using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 商家认证
    /// </summary>
    public enum MerchantCertification
    {
        /// <summary>
        /// 法人信息
        /// </summary>
        [Description("法人信息")]
        LegalPerson = 1,
        /// <summary>
        /// 营业执照
        /// </summary>
        [Description("营业执照")]
        BusinessLicense = 2
    }
}
