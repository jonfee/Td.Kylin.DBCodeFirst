using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 平台配置
	/// </summary>
	public class Luckydraw_PlatformConfig
    {
		/// <summary>
		/// ID
		/// </summary>
		public long ConfigID
		{
			get;
			set;
		}
		/// <summary>
		/// 中奖概率(范围：0-100)
		/// </summary>
		public short Probability
		{
			get;
			set;
		}
		/// <summary>
		/// 通用券生成比例(范围：0-100)
		/// </summary>
		public short GlobalTicketProportion
		{
			get;
			set;
		}
		/// <summary>
		/// 休眠起始时间
		/// </summary>
		public TimeSpan ExclusionStartTime
		{
			get;
			set;
		}
		/// <summary>
		/// 休眠结束时间
		/// </summary>
		public TimeSpan ExclusionEndTime
		{
			get;
			set;
		}
		

	}
}
