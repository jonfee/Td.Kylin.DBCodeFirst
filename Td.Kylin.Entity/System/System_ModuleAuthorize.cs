using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统模块接口授权
    /// </summary>
    [Table("System_ModuleAuthorize", Schema = "dbo")]
    public class System_ModuleAuthorize
    {
        ///<summary>
        ///服务系统编号（系统硬编码代号）
        ///</summary>
        [Column(TypeName = "varchar(10)")]
        public string ServerID { get; set; }

        ///<summary>
        ///模块编号(系统硬编码代号)
        ///</summary>
        [Column(TypeName = "varchar(10)")]
        public string ModuleID { get; set; }

        ///<summary>
        ///密钥
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string AppSecret { get; set; }

        ///<summary>
        ///角色(1管理员，2编辑者，4使用者）
        ///</summary>
        public int Role { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        ///<summary>
        ///更新时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime UpdateTime { get; set; }

    }
}
