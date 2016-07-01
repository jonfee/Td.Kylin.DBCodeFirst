using System;

using Td.ComponentModel;

namespace Td.Kylin.EnumLibrary
{
	/// <summary>
	/// 系统业务。
	/// </summary>
	public enum BusinessType : short
    {
		/// <summary>
		/// 上门服务。
		/// </summary>
		[Description("上门服务")]
		VisitingService = 1,

		/// <summary>
		/// 预约服务。
		/// </summary>
		[Description("预约服务")]
		AppointmentService = 2,

		/// <summary>
		/// 跑腿服务。
		/// </summary>
		[Description("跑腿服务")]
		LegworkService = 4
	}
}