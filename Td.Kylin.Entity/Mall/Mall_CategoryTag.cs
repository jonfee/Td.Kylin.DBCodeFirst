
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商品分类标签
    /// </summary>
    [Table("Mall_CategoryTag", Schema = "dbo")]
    public class Mall_CategoryTag
    {
        ///<summary>
        ///标签ID
        ///</summary>
        public long TagID { get; set; }

        ///<summary>
        ///商品类目ID
        ///</summary>
        public long CategoryID { get; set; }

        ///<summary>
        ///商品标签名称
        ///</summary>
        [Column(TypeName = "nvarchar(8)")]
        public string TagName { get; set; }

        ///<summary>
        ///商品数
        ///</summary>
        public int ProductNumber { get; set; }

        ///<summary>
        ///搜索次数
        ///</summary>
        public int SearchTimes { get; set; }

        ///<summary>
        ///排序值
        ///</summary>
        public int OrderNo { get; set; }

        ///<summary>
        ///标签创建时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
