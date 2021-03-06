﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统提供的商家上门/预约业务
    /// </summary>
    [Table("KylinService_Business")]
    public class KylinService_Business : BaseEntity
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        public long IndustryID { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        /// <summary>
        /// 业务类型（如：上门|预约）
        /// </summary>
        public int BusinessType { get; set; }

        /// <summary>
        /// 是否已开通线上服务（未开通时表示不能进行业务操作，如：上门服务|预约服务）
        /// </summary>
        public bool IsOpenService { get; set; }

        /// <summary>
        /// 报价方式（枚举：下单时报价｜上门时报价等）
        /// </summary>
        public int QuoteWays { get; set; }

        /// <summary>
        /// 付款方类型（枚举：下单方｜服务方）
        /// </summary>
        public int PayerType { get; set; }

        /// <summary>
        /// 是否允许个人开展业务
        /// </summary>
        public bool AllowPerson { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Icon { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// 是否被禁用
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// 标记状态（枚举以2的N次方定义，多个状态时累加）
        /// </summary>
        public int TagStatus { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }
    }
}
