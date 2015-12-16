
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 用户使用设备
    /// </summary>
    [Table("User_Device",Schema ="dbo")]
    public class User_Device
	{
        ///<summary>
        ///数据ID
        ///</summary>
        [Key]
        public long DeviceID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}

        ///<summary>
        ///设备类型(如：iphone 6s,小米 5S)
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(20)]
        public string DeviceName{get;set;}
				
		///<summary>
		///设备操作系统
		///</summary>
		public int? OS{get;set;}

        ///<summary>
        ///系统版本
        ///</summary>
        [Column(TypeName = "varchar"), MaxLength(15)]
        public string Version{get;set;}
				
		///<summary>
		///登陆次数
		///</summary>
		public int Logins{get;set;}
				
		///<summary>
		///最后活动时间
		///</summary>
		public DateTime LastTime{get;set;}
				
	}
}
