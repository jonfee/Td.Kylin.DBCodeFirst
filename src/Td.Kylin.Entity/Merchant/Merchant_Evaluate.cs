﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家评价记录
    /// </summary>
	[Table("Merchant_Evaluate")]
    public class Merchant_Evaluate : BaseEntity
    {
        ///<summary>
        ///评价ID
        ///</summary>
        public long EvaluateID { get; set; }

        ///<summary>
        ///快照ID
        ///</summary>
        public long SnapshotID { get; set; }

        ///<summary>
        ///订单ID
        ///</summary>
        public long OrderID { get; set; }
        /// <summary>
        /// 商家ID
        /// </summary>
        public long MerchantID { get; set; }
        ///<summary>
        ///商品ID
        ///</summary>
        public long ProductID { get; set; }

        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///评价等级
        ///</summary>
        public int EvaluateLevel { get; set; }

        ///<summary>
        ///评价内容
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Contents { get; set; }

        ///<summary>
        ///评价时间
        ///</summary>

        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }

        ///<summary>
        ///回复内容
        ///</summary>
        public string ReplyContents { get; set; }

        ///<summary>
        ///回复时间
        ///</summary>

        [Column(TypeName = "datetime")]public DateTime? ReplyTime { get; set; }

        ///<summary>
        ///是否已删除
        ///</summary>
        public bool IsDelete { get; set; }

    }
}
