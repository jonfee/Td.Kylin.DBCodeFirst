using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    ///     配送订单任务表
    /// </summary>
    [Table("Distribution_OrderSchedule")]
    public class Distribution_OrderSchedule
    {
        /// <summary>
        /// 	主键
        /// </summary>
        public long ScheduleId
        {
            get;
            set;
        }

        /// <summary>
        /// 	订单ID, 关联 Distribution_Order 表
        /// </summary>
        public long OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 	指派类型，关联 Distribution_AssignType 表
        /// </summary>
        public short AssignType
        {
            get;
            set;
        }


        /// <summary>
        /// 配送员ID
        /// </summary>
        public long MemberId
        {
            get;
            set;
        }

        /// <summary>
        /// 	指派人员ID
        /// </summary>
        public long? Operator
        {
            get;
            set;
        }

        /// <summary>
        /// 指派人员名称
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string OperatorName
        {
            get;
            set;
        }

        /// <summary>
        /// 	指派时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime AssignTime
        {
            get;
            set;
        }

        /// <summary>
        /// 是否处理
        /// </summary>
        public bool IsHandle
        {
            get;
            set;
        }

        /// <summary>
        /// 处理动作，关联 Distribution_HandleAction 枚举
        /// </summary>
        public short? HandleAction
        {
            get;
            set;
        }

        /// <summary>
        /// 	处理时间
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime? HandleTime
        {
            get;
            set;
        }

        /// <summary>
        /// 	处理人员ID
        /// </summary>
        public long? Handler
        {
            get;
            set;
        }

        /// <summary>
        /// 	处理人员名称
        /// </summary>
        [Column(TypeName = "nvarchar(10)")]
        public string HandlerName
        {
            get;
            set;
        }
    }
}