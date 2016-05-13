using System;
using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 工作人员业务审核状态。
	/// </summary>
    public enum WorkerBusinessAuditStatus : short
    {
		/// <summary>
		/// 审核中
		/// </summary>
		[Description("审核中")]
		Auditing = 1,

		/// <summary>
		/// 审核通过
		/// </summary>
		[Description("审核通过")]
		Passed = 2,

		/// <summary>
		/// 未通过
		/// </summary>
		[Description("未通过")]
		Failed = 3
	}
}
