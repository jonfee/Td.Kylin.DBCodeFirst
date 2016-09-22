using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.EnumLibrary
{
    /// <summary>
    /// 运费计价方式
    /// </summary>
    public enum FreightValuationType
    {
        /// <summary>
        /// 按件数
        /// </summary>
        [Description("按件数")]
        Items =1,
        /// <summary>
        /// 按重量（单位：每公斤）
        /// </summary>
        [Description("按重量")]
        Weight =2
    }
}
