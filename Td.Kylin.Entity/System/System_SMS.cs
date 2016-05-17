using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 系统短信
    /// </summary>
    [Table("System_SMS")]
    public class System_SMS : BaseEntity
    {
        ///<summary>
        ///数据ID
        ///</summary>
        public Guid Id { get; set; }

        ///<summary>
        ///手机号码
        ///</summary>
        [Column(TypeName = "nvarchar(11)")]
        public string Phone { get; set; }

        ///<summary>
        ///类型（注册、修改密码等）
        ///</summary>
        public int Type { get; set; }

        ///<summary>
        ///短信内容
        ///</summary>
        [Column(TypeName = "nvarchar(200)")]
        public string Content { get; set; }

        ///<summary>
        ///验证码，最长6位置
        ///</summary>
        [Column(TypeName = "nvarchar(6)")]
        public string Code { get; set; }

        ///<summary>
        ///是否使用
        ///</summary>
        public bool Used { get; set; }

        ///<summary>
        ///过期时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime Expires { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>
        
        [Column(TypeName = "datetime")]public DateTime CreateTime { get; set; }

    }
}
