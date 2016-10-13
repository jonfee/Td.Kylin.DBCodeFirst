using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    ///  优惠券定义表
    /// </summary>
    [Table("Coupon_Define")]
    public class Coupon_Define
    {
        /// <summary>
        /// 优惠券定义ID，主键
        /// </summary>
        public long DefineID { get; set; }
        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaID { get; set; }
        /// <summary>
        /// 优惠券类型，引用 Coupon_Type 枚举
        /// </summary>
        public short Type { get; set; }
        /// <summary>
        /// 	优惠券名称
        /// </summary>
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        /// <summary>
        /// 面值
        /// </summary>
        public decimal Denomination { get; set; }
        /// <summary>
        /// 发放数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int Balance { get; set; }
        /// <summary>
        /// 有效时间(起)
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 有效时间(止)
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 排列顺序
        /// </summary>
        public int SortOrder { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName ="datetime")]
        public DateTime UpdatedTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
