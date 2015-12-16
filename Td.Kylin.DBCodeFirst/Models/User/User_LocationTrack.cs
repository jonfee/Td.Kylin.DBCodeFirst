﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 用户位置轨迹
    /// </summary>
    [Table("User_LocationTrack", Schema = "dbo")]
    public class User_LocationTrack
	{
        ///<summary>
        ///数据ID
        ///</summary>
        [Key]
        public long TrackID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///经度
		///</summary>
		public Single Longitude{get;set;}
				
		///<summary>
		///纬度
		///</summary>
		public Single Latitude{get;set;}
				
		///<summary>
		///建立时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
