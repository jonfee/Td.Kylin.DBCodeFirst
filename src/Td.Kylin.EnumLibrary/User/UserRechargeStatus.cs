using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.EnumLibrary.User
{
    /// <summary>
    /// 用户充值状态
    /// </summary>
    public enum UserRechargeStatus
    {
        /// <summary>
        /// 充值中
        /// </summary>
        Rechargeing = 1,
        /// <summary>
        /// 充值成功
        /// </summary>
        Success = 2,
        /// <summary>
        /// 充值失败
        /// </summary>
        Fail = 3
    }
}
