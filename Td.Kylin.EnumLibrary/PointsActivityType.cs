using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 影响积分的业务活动类型
    /// </summary>
    public enum PointsActivityType
    {
        /// <summary>
        /// 完成注册
        /// </summary>
        [Description("完成注册")]
        Register = 1,
        /// <summary>
        /// 上传头像
        /// </summary>
        [Description("上传头像")]
        UploadHeadPhoto = 2,
        /// <summary>
        /// 完善基本资料
        /// </summary>
        [Description("完善基本资料")]
        FinishInfomation = 3,
        /// <summary>
        /// 通过实名认证
        /// </summary>
        [Description("通过实名认证")]
        RealNameCertification = 4,
        /// <summary>
        /// 签到
        /// </summary>
        [Description("签到")]
        SignIn = 5,
        /// <summary>
        /// 帖子点赞
        /// </summary>
        [Description("帖子点赞")]
        ClickLike = 6,
        /// <summary>
        /// 发表帖子
        /// </summary>
        [Description("发表帖子")]
        PublishTopic = 7,
        /// <summary>
        /// 回复帖子
        /// </summary>
        [Description("回复帖子")]
        ReplyTopic = 8,
        /// <summary>
        /// 成功邀请好友注册
        /// </summary>
        [Description("成功邀请好友注册")]
        InviteUserRegister = 9,
        /// <summary>
        /// 帖子被置顶
        /// </summary>
        [Description("帖子被置顶")]
        TopicStick = 10,
        /// <summary>
        /// 分享内容
        /// </summary>
        [Description("分享内容")]
        ShareData = 11,
        /// <summary>
        /// 反馈信息
        /// </summary>
        [Description("反馈信息")]
        Feedback = 12,
        /// <summary>
        /// 创建简历
        /// </summary>
        [Description("创建简历")]
        CreateResume = 13,
        /// <summary>
        /// 订单交易完成
        /// </summary>
        [Description("订单交易完成")]
        OrderFinish = 14,
        /// <summary>
        /// 评价订单/商品/服务
        /// </summary>
        [Description("评价")]
        Evaluate = 15,
        /// <summary>
        /// 完善收货地址
        /// </summary>
        [Description("完善收货地址")]
        FinishReceiptAddress = 16,
        /// <summary>
        /// 添加好友
        /// </summary>
        [Description("添加好友")]
        AddFriend = 17,
        /// <summary>
        /// 收藏
        /// </summary>
        [Description("收藏")]
        StoreUp = 18
    }
}
