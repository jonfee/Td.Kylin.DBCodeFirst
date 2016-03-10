using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 购物车
    /// </summary>
    [Table("Mall_ShoppingCart")]
    public class Mall_ShoppingCart : BaseEntity
    {		
		///<summary>
		///购物车ID
		///</summary>
		public long CartID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///关联商品ID
		///</summary>
		public long ProductID{get;set;}
				
		///<summary>
		///Sku编号ID
		///</summary>
		public long SkuID{get;set;}
				
		///<summary>
		///数量
		///</summary>
		public int Number{get;set;}

        ///<summary>
        ///加入购物车时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime{get;set;}

        ///<summary>
        ///最后更新时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime{get;set;}
				
	}
}
