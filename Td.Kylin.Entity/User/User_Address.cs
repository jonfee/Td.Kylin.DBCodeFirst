
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 用户地址库
    /// </summary>
    [Table("User_Address")]
    public class User_Address : BaseEntity
    {
        ///<summary>
        ///地址ID
        ///</summary>
        public long AddressID { get; set; }

        ///<summary>
        ///用户ID
        ///</summary>
        public long UserID { get; set; }

        ///<summary>
        ///地址使用类型（如：收货地址等）
        ///</summary>
        public int AddressUseType { get; set; }

        ///<summary>
        ///地址类型（如：公司，家）
        ///</summary>
        public int AddressType { get; set; }

        ///<summary>
        ///小区/区域
        ///</summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Community { get; set; }

        ///<summary>
        ///详细地址
        ///</summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        ///<summary>
        ///邮编
        ///</summary>
        [Column(TypeName = "char(6)")]
        public string PostCode { get; set; }

        ///<summary>
        ///纬度
        ///</summary>
        public Single Latitude { get; set; }

        ///<summary>
        ///经度
        ///</summary>
        public Single Longitude { get; set; }

        ///<summary>
        ///联系人
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Linkman { get; set; }

        ///<summary>
        ///联系电话
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }

        ///<summary>
        ///是否默认
        ///</summary>
        public bool IsDefault { get; set; }

        ///<summary>
        ///数据创建时间
        ///</summary>

        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

    }
}
