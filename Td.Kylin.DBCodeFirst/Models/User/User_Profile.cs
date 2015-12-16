using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 用户附属资料
    /// </summary>
    [Table("User_Profile", Schema = "dbo")]
    public class User_Profile
	{
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID{get;set;}
				
		///<summary>
		///性别
		///</summary>
		public int Sex{get;set;}
				
		///<summary>
		///出生日期
		///</summary>
		public DateTime? BothBirthday{get;set;}

        ///<summary>
        ///现居地
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(100)]
        public string PresentAddress{get;set;}

        ///<summary>
        ///个性签名
        ///</summary>
        [Column(TypeName = "nvarchar"), MaxLength(200)]
        public string Signature{get;set;}
				
	}
}
