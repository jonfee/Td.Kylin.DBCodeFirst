namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 岗位福利
    /// </summary>
    public enum JobWelfare
    {
        /// <summary>
        /// 五险一金
        /// </summary>
        WXYJ = 1,
        /// <summary>
        /// 免费班车
        /// </summary>
        MFBC = 2,
        /// <summary>
        /// 员工旅游
        /// </summary>
        YGLY = 4,
        /// <summary>
        /// 交通补贴
        /// </summary>
        JTBT = 8,
        /// <summary>
        /// 餐饮补贴
        /// </summary>
        CYBT = 16,
        /// <summary>
        /// 话费补贴
        /// </summary>
        HFBT = 32,
        /// <summary>
        /// 专业培训
        /// </summary>
        ZYPX = 64,
        /// <summary>
        /// 出国机会
        /// </summary>
        CGJH = 128,
        /// <summary>
        /// 绩效奖金
        /// </summary>
        JXJJ = 256,
        /// <summary>
        /// 股票期权
        /// </summary>
        GPQQ = 512,
        /// <summary>
        /// 年终奖金
        /// </summary>
        NZJJ = 1024,
        /// <summary>
        /// 定期体检
        /// </summary>
        DQTJ = 2048,
        /// <summary>
        /// 弹性工作
        /// </summary>
        TXGZ = 4096
    }

    /// <summary>
    /// 工作经验
    /// </summary>
    public enum WorkExperience
    {
        /// <summary>
        /// 无经验
        /// </summary>
        None = 1,
        /// <summary>
        /// 在读学生
        /// </summary>
        Student = 2,
        /// <summary>
        /// 应届毕业生
        /// </summary>
        Graduate = 3,
        /// <summary>
        /// 一年以上
        /// </summary>
        OneYear = 4,
        /// <summary>
        /// 两年以上
        /// </summary>
        TwoYear = 5,
        /// <summary>
        /// 三年以上
        /// </summary>
        ThreeYear = 6,
        /// <summary>
        /// 五年以上
        /// </summary>
        FiveYear = 7,
        /// <summary>
        /// 十年以上
        /// </summary>
        TenYear = 8
    }

    /// <summary>
    /// 工作性质
    /// </summary>
    public enum JobNature
    {
        /// <summary>
        /// 全职
        /// </summary>
        FullTime=1,
        /// <summary>
        /// 兼职
        /// </summary>
        PartTime=2,
    }

    /// <summary>
    /// 招聘信息推荐
    /// </summary>
    public enum JobRecommend
    {
        /// <summary>
        /// 推荐
        /// </summary>
        Recommend=1,
        /// <summary>
        /// 置顶
        /// </summary>
        Top=2
    }

    /// <summary>
    /// 简历投递状态
    /// </summary>
    public enum SendResumeStatus
    {
        /// <summary>
        /// 新申请
        /// </summary>
        Apply=1,
        /// <summary>
        /// 已沟通
        /// </summary>
        Contacted=2,
        /// <summary>
        /// 不合适
        /// </summary>
        NoGood=4
    }

    /// <summary>
    /// 到岗时间
    /// </summary>
    public enum GangTime
    {
        /// <summary>
        /// 随时
        /// </summary>
        AnyTime=1,
        /// <summary>
        /// 一周以内
        /// </summary>
        OneWeek=2,
        /// <summary>
        /// 一个月以内
        /// </summary>
        OneMonth=4,
        /// <summary>
        /// 待定
        /// </summary>
        NotSure=8
    }

    /// <summary>
    /// 简历状态
    /// </summary>
    public enum ResumeStatus
    {
        /// <summary>
        /// 正在找工作
        /// </summary>
        Looking=1,
        /// <summary>
        /// 观望好的工作机会
        /// </summary>
        WaitAndSee=2,
        /// <summary>
        /// 暂时不想换工作
        /// </summary>
        Unthink=4
    }
}
