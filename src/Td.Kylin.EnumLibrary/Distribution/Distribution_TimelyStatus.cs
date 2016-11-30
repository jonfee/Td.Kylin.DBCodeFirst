using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 同城配送状态
    /// </summary>
    public enum Distribution_TimelyStatus
    {
        /// <summary>
        /// 待指派
        /// </summary>
        [Description("待指派")]
        WartingAssign = 1 ,
        /// <summary>
        /// 待接单
        /// </summary>
        [Description("待接单")]
        WaitingConfirm = 2,
        /// <summary>
        /// 取货中
        /// </summary>
        [Description("取货中")]
        InPickup = 3,
        /// <summary>
        /// 送货中
        /// </summary>
        [Description("送货中")]
        InDeliver =4 ,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Completed = 5,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled = 6
    }
}
