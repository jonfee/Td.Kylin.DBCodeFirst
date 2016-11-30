using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.Distribution
{
    /// <summary>
    /// 配送订单明细
    /// </summary>
    [Table("Distribution_OrderDetail")]
    public class Distribution_OrderDetail
    {
        /// <summary>
        /// 主键，明细ID
        /// </summary>
        public long DetailId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单ID, 关联 Distribution_Order 表
        /// </summary>
        public long OrderId
        {
            get;
            set;
        }
        /// <summary>
        /// 取货仓库，关联 Distribution_Warehouse 表
        /// </summary>
        public long WarehouseId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品ID
        /// </summary>
        public long? ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// 	物品名称
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string ProductName
        {
            get;
            set;
        }

        /// <summary>
        /// 	物品规格
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ProductSKU
        {
            get;
            set;
        }

        /// <summary>
        /// 物品图片
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string ProductImage
        {
            get;
            set;
        }

        /// <summary>
        /// 物品数量
        /// </summary>
        public int ProductCount
        {
            get;
            set;
        }


        /// <summary>
        /// 物品重量
        /// </summary>
        public float ProductWeight
        {
            get;
            set;
        }
    }
}
