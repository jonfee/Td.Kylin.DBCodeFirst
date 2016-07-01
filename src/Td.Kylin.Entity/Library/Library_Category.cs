using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 产品库分类
    /// </summary>
    [Table("Library_Category")]
    public class Library_Category : BaseEntity
    {
        ///<summary>
        ///商品类目ID
        ///</summary>
        public long CategoryID { get; set; }
        ///<summary>
        ///类目名称
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
        ///<summary>
        ///图标
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string Ico { get; set; }
        ///<summary>
        ///类目描述
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }

        ///<summary>
        ///排序值
        ///</summary>
        public int OrderNo { get; set; }

        ///<summary>
        ///是否已禁用
        ///</summary>
        public bool Disabled { get; set; }

        ///<summary>
        ///是否已逻辑删除
        ///</summary>
        public bool IsDelete { get; set; }

        ///<summary>
        ///商品数
        ///</summary>
        public int ProductNumber { get; set; }

        public long ParentID { get; set; }

        public string Layer { get; set; }

        public int Depth { get; set; }

        ///<summary>
        ///数据建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        ///<summary>
        ///数据删除删除时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime DeleteTime { get; set; }

    }
}
