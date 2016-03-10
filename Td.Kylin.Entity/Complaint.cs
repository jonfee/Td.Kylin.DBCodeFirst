
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 投诉/举报
    /// </summary>
    [Table("Complaint")]
    public class Complaint : BaseEntity
    {		
		///<summary>
		///投诉ID
		///</summary>
		public long ComplaintsID{get;set;}
				
		///<summary>
		///投诉类型
		///</summary>
		public int ComplaintsType{get;set;}

        ///<summary>
        ///投诉的对象ID
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string DataID{get;set;}

        ///<summary>
        ///原因
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Reason{get;set;}

        ///<summary>
        ///投诉详述
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Content{get;set;}
				
		///<summary>
		///投诉人身份类型
		///</summary>
		public int IdentityType{get;set;}
				
		///<summary>
		///投诉人ID
		///</summary>
		public long ComplainantID{get;set;}

        ///<summary>
        ///投诉人名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string ComplainantName{get;set;}

        ///<summary>
        ///投诉人联系电话
        ///</summary>
        [Column(TypeName = "varchar(20)")]
        public string ComplainantPhone{get;set;}
				
		///<summary>
		///处理状态
		///</summary>
		public int ComplaintsStatus{get;set;}

        ///<summary>
        ///投诉时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime{get;set;}
				
	}
}
