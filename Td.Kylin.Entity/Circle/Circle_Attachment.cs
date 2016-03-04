
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 社区帖子附件
    /// </summary>
    [Table("Circle_Attachment",Schema ="dbo")]
    public class Circle_Attachment : BaseEntity
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
        [Column(TypeName = "varchar(50)")]
        public string FileType{get;set;}

        ///<summary>
        ///文件名称
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Filename{get;set;}

        ///<summary>
        ///存储路径
        ///</summary>
        [Column(TypeName = "varchar(255)")]
        public string FilePath{get;set;}
				
		///<summary>
		///文件大小
		///</summary>
		public long FileSize{get;set;}

        ///<summary>
        ///上传时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime UploadTime{get;set;}
				
		///<summary>
		///是否逻辑删除
		///</summary>
		public bool IsDelete{get;set;}

        ///<summary>
        ///逻辑删除时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime DeleteTime{get;set;}
				
	}
}
