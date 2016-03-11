
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 管理员权限
    /// </summary>
    [Table("Admin_Permission")]
    public class Admin_Permission : BaseEntity
    {
        ///<summary>
        ///管理员ID
        ///</summary>
        [Column(TypeName ="bigint")]
        public long AdminID{get;set;}

        ///<summary>
        ///模块编号(系统硬编码代号)
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string ModuleID{get;set;}
				
		///<summary>
		///数据状态(正常、删除)
		///</summary>
		public bool DataStatus{get;set;}

        ///<summary>
        ///建立时间
        ///</summary>
        
        public DateTime CreateTime{get;set;}
				
	}
}
