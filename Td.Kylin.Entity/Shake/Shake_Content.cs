using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 摇一摇数据内容
    /// </summary>
    [Table("Shake_Content", Schema = "dbo")]
    public partial class Shake_Content
    {
        ///<summary>
        ///主题ID
        ///</summary>
        public long ContentID { get; set; }

        ///<summary>
        ///推荐管理员ID
        ///</summary>
        public long PushAdminID { get; set; }

        ///<summary>
        ///圈子，商品，企业，招聘，活动、推广、其他
        ///</summary>
        public int Category { get; set; }

        ///<summary>
        ///类型（社区事件帖，社区活动，社区二手商品、直营商城，限时福利，工作，推广的企业，推广的产品，平台现金，平台红包、广告引导）
        ///</summary>
        public int Subject { get; set; }

        ///<summary>
        ///数据对象主ID（如：帖子ID,商品ID）
        ///</summary>
        public long DataID { get; set; }

        ///<summary>
        ///数据对象关联ID（如：商品规格ID）
        ///</summary>
        public long DataRelateID { get; set; }

        ///<summary>
        ///标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        ///<summary>
        ///图片
        ///</summary>
        [Column(TypeName = "varchar(255)")]
        public string Pic { get; set; }

        ///<summary>
        ///内容
        ///</summary>
        [Column(TypeName = "nvarchar(255)")]
        public string Content { get; set; }

        ///<summary>
        ///原价
        ///</summary>
        public decimal CostPrice { get; set; }

        ///<summary>
        ///价格
        ///</summary>
        public decimal Price { get; set; }

        ///<summary>
        ///数量（商品时可能会限制加入摇一摇活动的数量）
        ///</summary>
        public int Number { get; set; }

        ///<summary>
        ///目标URL
        ///</summary>
        [Column(TypeName = "varchar(255)")]
        public string Url { get; set; }

        ///<summary>
        ///命中率
        ///</summary>
        public double Odds { get; set; }

        ///<summary>
        ///已经命中次数
        ///</summary>
        public int Count { get; set; }

        ///<summary>
        ///确定次数（如商品被购买，帖子被查看，红包被领取）
        ///</summary>
        public int ConfirmCount { get; set; }

        ///<summary>
        ///审核状态
        ///</summary>
        public int AuditStatus { get; set; }

        ///<summary>
        ///禁用数据
        ///</summary>
        public bool Disable { get; set; }

        ///<summary>
        ///开始时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }

        ///<summary>
        ///结束时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }

        ///<summary>
        ///最后使用时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime LastTime { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
