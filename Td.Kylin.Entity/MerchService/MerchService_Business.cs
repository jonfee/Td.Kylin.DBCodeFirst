using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商家服务类目下的业务
    /// </summary>
    [Table("MerchService_Business", Schema = "dbo")]
    public class MerchService_Business
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        public long BusinessID { get; set; }

        /// <summary>
        /// 所属服务分类
        /// </summary>
        public long CategoryID { get; set; }

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
        /// 图标
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Icon { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// 是否已开通服务（未开通时表示不能进行业务操作，如：上门服务|预约服务）
        /// </summary>
        public bool IsOpenService { get; set; }

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
        public DateTime CreateTime { get; set; }
    }
}
