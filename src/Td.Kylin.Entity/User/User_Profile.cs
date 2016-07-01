using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户附属资料
    /// </summary>
    [Table("User_Profiles")]
    public class User_Profiles : BaseEntity
    {
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID{get;set;}

        /// <summary>
        /// 姓名
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        ///<summary>
        ///性别
        ///</summary>
        public int Sex{get;set;}

        /// <summary>
        /// 籍贯
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string JiGuan { get; set; }

        ///<summary>
        ///出生日期
        ///</summary>
        [Column(TypeName = "datetime")]public DateTime BothBirthday{get;set;}

        /// <summary>
        /// 婚姻状况（枚举：如：未婚｜已婚｜离异｜丧偶等）
        /// </summary>
        public int MaritalStatus { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Column(TypeName = "nvarchar(18)")]
        public string CardID { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string Nation { get; set; }

        /// <summary>
        /// 最高学历
        /// </summary>
        public int MaxEducation { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }

        ///<summary>
        ///现居地
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string PresentAddress{get;set;}

        /// <summary>
        /// 普通话程度（枚举：如：一般｜良好｜熟练｜精通）
        /// </summary>
        public int MandarinLevel { get; set; }

        ///<summary>
        ///个性签名
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Signature{get;set;}
				
	}
}
