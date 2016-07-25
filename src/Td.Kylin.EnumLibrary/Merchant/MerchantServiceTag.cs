﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
    public enum MerchantServiceTag
    {
        /// <summary>
        /// 上门
        /// </summary>
        [Description("上门")]
        Call = 1,
        /// <summary>
        /// 自提
        /// </summary>
        [Description("自提")]
        Take = 2
    }
}