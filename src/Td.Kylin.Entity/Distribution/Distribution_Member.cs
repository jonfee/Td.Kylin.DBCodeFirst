using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 配送员
    /// </summary>
    [Table("Distribution_Member")]
    public class Distribution_Member
    {
        /// <summary>
        /// 主键，关联 User_Account 表
        /// </summary>
        public int MemberId
        {
            get;
            set;
        }

        /// <summary>
        /// 所属区域
        /// </summary>
        public int AreaId
        {
            get;
            set;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender
        {
            get;
            set;
        }

        /// <summary>
        /// 	头像标识
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Avatar
        {
            get;
            set;
        }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Column(TypeName = "varchar(18)")]
        public string IdentityNo
        {
            get;
            set;
        }

        /// <summary>
        /// 设备号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string DeviceCode
        {
            get;
            set;
        }

        /// <summary>
        /// 	推送号
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string PushCode
        {
            get;
            set;
        }

        /// <summary>
        /// 工作状态
        /// </summary>
        public bool IsWorking
        {
            get;
            set;
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedTime
        {
            get;
            set;
        }

        /// <summary>
        /// 创建人
        /// </summary>
        public long Creator
        {
            get;
            set;
        }

    }
}
