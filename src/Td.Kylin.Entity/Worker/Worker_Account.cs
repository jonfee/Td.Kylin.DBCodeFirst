using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 服务职员账户
    /// </summary>
    [Table("Worker_Account")]
    public class Worker_Account : BaseEntity
    {
        /// <summary>
        /// 服务员ID。
        /// </summary>
        public long WorkerID
        {
            get;
            set;
        }

        /// <summary>
        /// 真实姓名。
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// 工作状态。
        /// </summary>
        public short WorkingState
        {
            get;
            set;
        }

        /// <summary>
        /// 账户状态。
        /// </summary>
        public short AccountStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 激活时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ActiveTime
        {
            get;
            set;
        }

        /// <summary>
        /// 激活时间。
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? AuditTime
        {
            get;
            set;
        }
        /// <summary>
        /// 默认所属区域ID。
        /// </summary>
        public int DefaultAreaID
        {
            get;
            set;
        }


        ///<summary>
        ///最后记录纬度
        ///</summary>
        public Single LastLatitude { get; set; }

        ///<summary>
        ///经度最后记录
        ///</summary>
        public Single LastLongitude { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceCode
        {
            get;
            set;
        }
        /// <summary>
        /// 推送号
        /// </summary>
        public string PushCode
        {
            get;
            set;
        }
    }
}     