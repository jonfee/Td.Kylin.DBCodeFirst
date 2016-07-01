using System;
using System.Collections.Generic;

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 工作人员账户状态。
	/// </summary>
	public enum WorkerAccountStatus : short
    {
		/// <summary>
		/// 待审核。
		/// </summary>
		[Description("待审核")]
		WaitingAudit = 1,

		/// <summary>
		/// 正常。
		/// </summary>
		[Description("正常")]
		Normal = 2,

		/// <summary>
		/// 禁用。
		/// </summary>
		[Description("禁用")]
		Disabled = 3
	}
}
