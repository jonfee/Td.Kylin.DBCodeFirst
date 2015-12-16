
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 社区用户等级规则
    /// </summary>
    [Table("Circle_Level", Schema = "dbo")]
    public class Circle_Level
	{		
		///<summary>
		///数据ID
		///</summary>
		public long LevelID{get;set;}

        ///<summary>
        ///等级名称
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(10)]
        public string Name{get;set;}
				
		///<summary>
		///最小积分
		///</summary>
		public int Min{get;set;}
				
		///<summary>
		///是否启用
		///</summary>
		public bool Enable{get;set;}
				
		///<summary>
		///创建时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
