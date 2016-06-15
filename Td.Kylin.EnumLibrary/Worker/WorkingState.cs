using System;
using System.Collections.Generic;

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 工作状态。
	/// </summary>
    public enum WorkingState : short
    {
		/// <summary>
		/// 正常。
		/// </summary>
		Enabled = 1,

		/// <summary>
		/// 收工。
		/// </summary>
		Disabled = 2
    }
}
