using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 摇一摇记录
    /// </summary>
    [Table("Shake_UserRecord")]
    public partial class Shake_UserRecord : BaseEntity
    {
        ///<summary>
        ///记录ID
        ///</summary>
        public long RecordID { get; set; }

        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///主题ID
        ///</summary>
        public long ContentID { get; set; }

        ///<summary>
        ///标题
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        ///<summary>
        ///原价
        ///</summary>
        public decimal CostPrice { get; set; }

        ///<summary>
        ///价格
        ///</summary>
        public decimal Price { get; set; }

        ///<summary>
        ///最后支付时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastPayTime { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

    }
}
