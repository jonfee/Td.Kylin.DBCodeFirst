using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商品SKU
    /// </summary>
    [Table("Mall_ProductSKU", Schema = "dbo")]
    public class Mall_ProductSKU : BaseEntity
    {		
		///<summary>
		///Sku编号ID
		///</summary>
		public long SkuID{get;set;}
				
		///<summary>
		///关联商品ID
		///</summary>
		public long ProductID{get;set;}

        ///<summary>
        ///规格名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Specs{get;set;}

        ///<summary>
        ///SKU码
        ///</summary>
        [Column(TypeName = "varchar(18)")]
        public string SKU{get;set;}

        ///<summary>
        ///规格展示图
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string Img{get;set;}
				
		///<summary>
		///库存
		///</summary>
		public int Inventory{get;set;}
				
		///<summary>
		///销售量
		///</summary>
		public int SoldNumber{get;set;}
				
		///<summary>
		///销售价
		///</summary>
		public decimal SalePrice{get;set;}

        /// <summary>
        /// 标识状态集
        /// </summary>
        public int TagStatus { get; set; }
				
		///<summary>
		///是否已逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///市场价
		///</summary>
		public decimal MarketPrice{get;set;}
				
	}
}
