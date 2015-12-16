using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 用户摇一摇记录
    /// </summary>
    [Table("User_ShakeRecord", Schema = "dbo")]
    public class User_ShakeRecord
	{
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID{get;set;}
				
		///<summary>
		///摇一摇次数
		///</summary>
		public int Count{get;set;}
				
		///<summary>
		///当日次数
		///</summary>
		public int TodayCount{get;set;}
				
		///<summary>
		///日上限次数
		///</summary>
		public int LimitCount{get;set;}
				
		///<summary>
		///最后一次摇的时间
		///</summary>
		public DateTime LastTime{get;set;}
				
		///<summary>
		///更新时间
		///</summary>
		public DateTime UpdatetTime{get;set;}
				
	}
}
