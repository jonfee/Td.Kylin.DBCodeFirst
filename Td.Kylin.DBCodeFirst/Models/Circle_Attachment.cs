
using System;

namespace Td.Kylin.DBCodeFirst.Models
{
	/// <summary>
	/// Circle_Attachment
	/// </summary>
	public partial class Circle_Attachment
	{		
		///<summary>
		///数据ID
		///</summary>
		public long AttachmentID{get;set;}
				
		///<summary>
		///用户ID
		///</summary>
		public long UserID{get;set;}
				
		///<summary>
		///图片文件
		///</summary>
		public bool IsImage{get;set;}
				
		///<summary>
		///文件类型
		///</summary>
		public string FileType{get;set;}
				
		///<summary>
		///文件名称
		///</summary>
		public string Filename{get;set;}
				
		///<summary>
		///存储路径
		///</summary>
		public string FilePath{get;set;}
				
		///<summary>
		///文件大小
		///</summary>
		public long FileSize{get;set;}
				
		///<summary>
		///上传时间
		///</summary>
		public DateTime UploadTime{get;set;}
				
		///<summary>
		///是否逻辑删除
		///</summary>
		public bool IsDelete{get;set;}
				
		///<summary>
		///逻辑删除时间
		///</summary>
		public DateTime DeleteTime{get;set;}
				
	}
}
