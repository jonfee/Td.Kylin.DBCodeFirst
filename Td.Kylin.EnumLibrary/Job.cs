

using Td.ComponentModel;

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
        [Description("五险一金")]
        WXYJ = 1,
        /// <summary>
        /// 免费班车
        /// </summary>
        [Description("免费班车")]
        MFBC = 2,
        /// <summary>
        /// 员工旅游
        /// </summary>
        [Description("员工旅游")]
        YGLY = 4,
        /// <summary>
        /// 交通补贴
        /// </summary>
        [Description("交通补贴")]
        JTBT = 8,
        /// <summary>
        /// 餐饮补贴
        /// </summary>
        [Description("餐饮补贴")]
        CYBT = 16,
        /// <summary>
        /// 话费补贴
        /// </summary>
        [Description("话费补贴")]
        HFBT = 32,
        /// <summary>
        /// 专业培训
        /// </summary>
        [Description("专业培训")]
        ZYPX = 64,
        /// <summary>
        /// 出国机会
        /// </summary>
        [Description("出国机会")]
        CGJH = 128,
        /// <summary>
        /// 绩效奖金
        /// </summary>
        [Description("绩效奖金")]
        JXJJ = 256,
        /// <summary>
        /// 股票期权
        /// </summary>
        [Description("股票期权")]
        GPQQ = 512,
        /// <summary>
        /// 年终奖金
        /// </summary>
        [Description("年终奖金")]
        NZJJ = 1024,
        /// <summary>
        /// 定期体检
        /// </summary>
        [Description("定期体检")]
        DQTJ = 2048,
        /// <summary>
        /// 弹性工作
        /// </summary>
        [Description("弹性工作")]
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
        [Description("无经验")]
        None = 1,
        /// <summary>
        /// 在读学生
        /// </summary>
        [Description("在读学生")]
        Student = 2,
        /// <summary>
        /// 应届毕业生
        /// </summary>
        [Description("应届毕业生")]
        Graduate = 3,
        /// <summary>
        /// 一年以上
        /// </summary>
        [Description("一年以上")]
        OneYear = 4,
        /// <summary>
        /// 两年以上
        /// </summary>
        [Description("两年以上")]
        TwoYear = 5,
        /// <summary>
        /// 三年以上
        /// </summary>
        [Description("三年以上")]
        ThreeYear = 6,
        /// <summary>
        /// 五年以上
        /// </summary>
        [Description("五年以上")]
        FiveYear = 7,
        /// <summary>
        /// 十年以上
        /// </summary>
        [Description("十年以上")]
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
        [Description("全职")]
        FullTime = 1,
        /// <summary>
        /// 兼职
        /// </summary>
        [Description("兼职")]
        PartTime = 2,
    }

    /// <summary>
    /// 招聘信息推荐
    /// </summary>
    public enum JobRecommend
    {
        /// <summary>
        /// 推荐
        /// </summary>
        [Description("推荐")]
        Recommend = 1,
        /// <summary>
        /// 置顶
        /// </summary>
        [Description("置顶")]
        Top = 2
    }

    /// <summary>
    /// 简历投递状态
    /// </summary>
    public enum SendResumeStatus
    {
        /// <summary>
        /// 新申请
        /// </summary>
        [Description("新申请")]
        Apply = 1,
        /// <summary>
        /// 已沟通
        /// </summary>
        [Description("已沟通")]
        Contacted = 2,
        /// <summary>
        /// 不合适
        /// </summary>
        [Description("不合适")]
        NoGood = 4
    }

    /// <summary>
    /// 到岗时间
    /// </summary>
    public enum GangTime
    {
        /// <summary>
        /// 随时
        /// </summary>
        [Description("随时")]
        AnyTime = 1,
        /// <summary>
        /// 一周以内
        /// </summary>
        [Description("一周以内")]
        OneWeek = 2,
        /// <summary>
        /// 一个月以内
        /// </summary>
        [Description("一个月以内")]
        OneMonth = 4,
        /// <summary>
        /// 待定
        /// </summary>
        [Description("待定")]
        NotSure = 8
    }

    /// <summary>
    /// 简历状态
    /// </summary>
    public enum ResumeStatus
    {
        /// <summary>
        /// 正在找工作
        /// </summary>
        [Description("正在找工作")]
        Looking = 1,
        /// <summary>
        /// 观望好的工作机会
        /// </summary>
        [Description("观望好的工作机会")]
        WaitAndSee = 2,
        /// <summary>
        /// 暂时不想换工作
        /// </summary>
        [Description("暂时不想换工作")]
        Unthink = 4
    }

    /// <summary>
    /// 职位类别推荐
    /// </summary>
    public enum JobCategoryRecommend
    {
        /// <summary>
        /// 热门职位
        /// </summary>
        [Description("热门职位")]
        Hot = 1
    }
}
