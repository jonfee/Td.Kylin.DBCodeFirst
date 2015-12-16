using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 商品SKU
    /// </summary>
    [Table("Mall_ProductSKU", Schema = "dbo")]
    public class Mall_ProductSKU
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
		public string Specs{get;set;}
				
		///<summary>
		///SKU码
		///</summary>
		public string SKU{get;set;}
				
		///<summary>
		///规格展示图
		///</summary>
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
