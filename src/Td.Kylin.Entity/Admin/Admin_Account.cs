﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 管理员账户
    /// </summary>
    [Table("Admin_Account")]
    public class Admin_Account : BaseEntity
    {
        ///<summary>
        ///管理员ID
        ///</summary>
        public long AdminID { get; set; }

        ///<summary>
        ///登陆账号
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Username { get; set; }

        ///<summary>
        ///登陆密码
        ///</summary>
        [Column(TypeName = "nvarchar(32)")]
        public string Password { get; set; }

        ///<summary>
        ///真实姓名
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Realname { get; set; }

        ///<summary>
        ///权限级别（枚举：AdminRole）
        ///</summary>
        public int PowerLevel { get; set; }

        ///<summary>
        ///登陆次数
        ///</summary>
        public int Logins { get; set; }

        ///<summary>
        ///最后登录时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime LastTime { get; set; }

        ///<summary>
        ///最后登录IP
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string LastIp { get; set; }

        ///<summary>
        ///数据状态(正常、删除)
        ///</summary>
        public bool DataStatus { get; set; }

        ///<summary>
        ///建立时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        ///<summary>
        ///UserPic
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string UserPic { get; set; }

    }
}
