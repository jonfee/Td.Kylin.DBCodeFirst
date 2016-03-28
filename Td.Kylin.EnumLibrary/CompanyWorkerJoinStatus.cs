using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 企业工作人员加入或服务状态
    /// </summary>
    public enum CompanyWorkerJoinStatus
    {
        /// <summary>
        /// 公司邀请中
        /// </summary>
        [Description("公司邀请中")]
        CompanyInvitation = 1,
        /// <summary>
        /// 拒绝公司邀请
        /// </summary>
        [Description("拒绝公司邀请")]
        RejectCompanyInvitaion = 2,
        /// <summary>
        /// 申请加入公司
        /// </summary>
        [Description("申请加入公司")]
        ApplyJoinCompany = 4,
        /// <summary>
        /// 申请加入公司失败
        /// </summary>
        [Description("申请加入公司失败")]
        ApplyJoinFailure = 8,
        /// <summary>
        /// 服务中
        /// </summary>
        [Description("服务中")]
        InServices = 16,
        /// <summary>
        /// 暂停服务
        /// </summary>
        [Description("暂停服务")]
        PauseServices = 32,
        /// <summary>
        /// 服务中止
        /// </summary>
        [Description("服务中止")]
        StopedServices = 64,
        /// <summary>
        /// 商家黑名单
        /// </summary>
        [Description("商家黑名单")]
        BlackList = 128
    }
}
