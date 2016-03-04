using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 商品
    /// </summary>
    [Table("Mall_Product", Schema = "dbo")]
    public class Mall_Product : BaseEntity
    {		
		///<summary>
		///商品ID
		///</summary>
		public long ProductID{get;set;}

        ///<summary>
        ///商品名称
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Name{get;set;}

        ///<summary>
        ///商品编号
        ///</summary>
        [Column(TypeName = "varchar(18)")]
        public string Code{get;set;}
				
		///<summary>
		///所属类目
		///</summary>
		public long CategoryID{get;set;}

        ///<summary>
        ///标签ID集合
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string TagIDs{get;set;}

        ///<summary>
        ///商家名称
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string VenderName{get;set;}

        ///<summary>
        ///发布者
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Publisher{get;set;}
				
		///<summary>
		///配送费
		///</summary>
		public decimal DeliveryFee{get;set;}

        ///<summary>
        ///主图
        ///</summary>
        [Column(TypeName = "varchar(100)")]
        public string MainPic{get;set;}

        ///<summary>
        ///商品展示图集
        ///</summary>
        [Column(TypeName = "varchar(500)")]
        public string Pics{get;set;}

        ///<summary>
        ///商品详情描述
        ///</summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Description{get;set;}
				
		///<summary>
		///库存
		///</summary>
		public int Inventory{get;set;}
				
		///<summary>
		///销售量
		///</summary>
		public int SoldNumber{get;set;}
				
		///<summary>
		///销售状态
		///</summary>
		public int SalesStatus{get;set;}
				
		///<summary>
		///标识状态集（推荐，新品，人气，摇一摇）
		///</summary>
		public int TagStatus{get;set;}
				
		///<summary>
		///是否已逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///排序值
		///</summary>
		public int OrderNo{get;set;}
				
		///<summary>
		///评价分值（介于0-5之间）
		///</summary>
		public double EvaluateScore{get;set;}

        ///<summary>
        ///数据建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime{get;set;}

        ///<summary>
        ///最后更新时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime{get;set;}
				
		///<summary>
		///促销ID
		///</summary>
		public long? PromotionID{get;set;}
				
	}
}
