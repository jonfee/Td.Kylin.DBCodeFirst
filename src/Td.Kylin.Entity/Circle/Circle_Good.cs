
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区商品帖信息
    /// </summary>
    [Table("Circle_Good")]
    public class Circle_Good : BaseEntity
    {		
		///<summary>
		///商品ID
		///</summary>
		public long GoodID{get;set;}
				
		///<summary>
		///主题ID
		///</summary>
		public long TopicID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///原价
		///</summary>
		public decimal Original{get;set;}
				
		///<summary>
		///商品帖子价格
		///</summary>
		public decimal Price{get;set;}
				
		///<summary>
		///损耗、新旧程度
		///</summary>
		public int Loss{get;set;}

        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string LinkMan{get;set;}

        ///<summary>
        ///电话
        ///</summary>
        [Column(TypeName = "nvarchar(13)")]
        public string Phone{get;set;}

        ///<summary>
        ///交易地点
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Address{get;set;}
				
		///<summary>
		///是否已出售
		///</summary>
		public bool Saled{get;set;}

        ///<summary>
        ///帖子发布时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime{get;set;}
				
	}
}
