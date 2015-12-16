
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.DBCodeFirst.Models
{
    /// <summary>
    /// 附件与帖子关联
    /// </summary>
    [Table("Circle_AttachmentUsage", Schema = "dbo")]
    public class Circle_AttachmentUsage
	{		
		///<summary>
		///附件ID
		///</summary>
		public long AttachmentID{get;set;}
				
		///<summary>
		///帖子ID
		///</summary>
		public long PostID{get;set;}
				
	}
}
