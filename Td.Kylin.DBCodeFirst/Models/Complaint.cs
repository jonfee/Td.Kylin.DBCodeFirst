
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Complaint
	/// </summary>
	public partial class Complaint
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
		public string DataID{get;set;}
				
		///<summary>
		///原因
		///</summary>
		public string Reason{get;set;}
				
		///<summary>
		///投诉详述
		///</summary>
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
		public string ComplainantName{get;set;}
				
		///<summary>
		///投诉人联系电话
		///</summary>
		public string ComplainantPhone{get;set;}
				
		///<summary>
		///处理状态
		///</summary>
		public int ComplaintsStatus{get;set;}
				
		///<summary>
		///投诉时间
		///</summary>
		public DateTime CreateTime{get;set;}
				
	}
}
