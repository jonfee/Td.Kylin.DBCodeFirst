
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区圈子
    /// </summary>
    [Table("Circle_Forum")]
    public class Circle_Forum : BaseEntity
    {
        ///<summary>
        ///版面圈子ID
        ///</summary>
        public long ForumID { get; set; }
        
        ///<summary>
        ///论坛分类ID
        ///</summary>
        public long CategoryID { get; set; }

        ///<summary>
        ///论坛名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ForumName { get; set; }

        ///<summary>
        ///论坛图标
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Logo { get; set; }

        ///<summary>
        ///论坛介绍
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        
        ///<summary>
        ///发帖类型2n次方
        ///</summary>
        public int PostType { get; set; }

        ///<summary>
        ///发帖等级限制
        ///</summary>
        public int PostLevel { get; set; }

        ///<summary>
        ///不需要审核等级限制
        ///</summary>
        public int PassLevel { get; set; }

        ///<summary>
        ///逻辑删除时间
        ///</summary>

        [Column(TypeName = "datetime")]public DateTime? DeleteTime { get; set; }

        ///<summary>
        ///是否禁用
        ///</summary>
        public bool Disabled { get; set; }

        ///<summary>
        ///是否逻辑删除
        ///</summary>
        public bool IsDelete { get; set; }

        ///<summary>
        ///数据建立时间
        ///</summary>
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }

        /// <summary>
        /// 区域运营数（即有多少区域在使用及运营）
        /// </summary>
        public int OperatorNumber { get; set; }
    }
}
