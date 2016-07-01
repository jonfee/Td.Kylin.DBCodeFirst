
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 附件与帖子关联
    /// </summary>
    [Table("Circle_AttachmentUsage")]
    public class Circle_AttachmentUsage : BaseEntity
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
