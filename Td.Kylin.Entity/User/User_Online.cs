using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户在线记录
    /// </summary>
    [Table("User_Online", Schema = "dbo")]
    public class User_Online : BaseEntity
    {
        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///登陆令牌
        ///</summary>
        [Column(TypeName = "varchar(50)")]
        public string Token { get; set; }

        ///<summary>
        ///登陆时间
        ///</summary>
        public DateTime LoginTime { get; set; }

        ///<summary>
        ///最后活动纬度
        ///</summary>
        public Single Latitude { get; set; }

        ///<summary>
        ///最后活动经度
        ///</summary>
        public Single Longitude { get; set; }

        ///<summary>
        ///最后活动时间
        ///</summary>
        [Column(TypeName = "datetime")]
        public DateTime ActiveTime { get; set; }

    }
}
