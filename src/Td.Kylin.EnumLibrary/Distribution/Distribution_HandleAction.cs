using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 订单处理动作
    /// </summary>
    public enum Distribution_HandleAction
    {
        /// <summary>
        /// 开始
        /// </summary>
        [Description("配送人员手动开始")]
        Start = 1 ,
        /// <summary>
        /// 关闭
        /// </summary>
        [Description("配送人员手动关闭")]
        Close = 2,
        /// <summary>
        /// 取消
        /// </summary>
        [Description("系统自动取消")]
        Cancel = 3
    }
}
