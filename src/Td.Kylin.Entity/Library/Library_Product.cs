using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Td.Kylin.Entity;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 产品
    /// </summary>
    [Table("Library_Product")]
    public class Library_Product : BaseEntity
    {
        ///<summary>
        ///商品ID
        ///</summary>
        public long ProductID { get; set; }
        ///<summary>
        ///商品名称
        ///</summary>
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        ///<summary>
        ///商品编号
        ///</summary>
        [Column(TypeName = "varchar(18)")]
        public string Code { get; set; }
        ///<summary>
        ///所属类目
        ///</summary>
        public long CategoryID { get; set; }
        ///<summary>
        ///主图
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string MainPic { get; set; }
        ///<summary>
        ///商品展示图集
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Pics { get; set; }
        ///<summary>
        ///商品详情描述
        ///</summary>
        [Column(TypeName = "text")]
        public string Description { get; set; }
        ///<summary>
        ///销售状态
        ///</summary>
        public int SalesStatus { get; set; }
        ///<summary>
        ///是否已逻辑删除
        ///</summary>
        public bool IsDelete { get; set; }
        ///<summary>
        ///排序值
        ///</summary>
        public int OrderNo { get; set; }
        ///<summary>
        ///数据建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        ///<summary>
        ///最后更新时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 产品参数
        /// </summary>
        public string ParameterDesc { get; set; }
        /// <summary>
        /// 产品来源（0：自定义；1：天猫超市；2：一号店）
        /// </summary>
        public int Source { get; set; }
        /// <summary>
        /// 产品来源路径
        /// </summary>
        public string SourceUrl { get; set; }
    }
}
