
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 签到记录
    /// </summary>
    [Table("Circle_CheckIn")]
    public class Circle_CheckIn : BaseEntity
    {		
		///<summary>
		///签到记录ID
		///</summary>
		public long CheckID{get;set;}
				
		///<summary>
		///签到用户ID
		///</summary>
		public long UserId{get;set;}

        ///<summary>
        ///签到时间
        ///</summary>
        
        public DateTime CheckTime{get;set;}

        /// <summary>
        /// 签到时所在的区域ID
        /// </summary>
        public int AreaID { get; set; }

        ///<summary>
		///纬度
		///</summary>
		public Single Latitude { get; set; }

        ///<summary>
        ///经度
        ///</summary>
        public Single Longitude { get; set; }

    }
}
