using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 区域配置
	/// </summary>
	[Table("Luckydraw_AreaConfig")]
	public class Luckydraw_AreaConfig
    {
		/// <summary>
		/// 区域ID，主键
		/// </summary>
		public int AreaID
		{
			get;
			set;
		}

		/// <summary>
		/// 抽奖说明
		/// </summary>
		[Column(TypeName = "nvarchar(MAX)")]
		public string Introduction
		{
			get;
			set;
		}

		/// <summary>
		/// 通用券剩余量
		/// </summary>
		public long GlobalTicketBalance
		{
			get;
			set;
		}
		/// <summary>
		/// 奖品券剩余量
		/// </summary>
		public long PrizeTicketBalance
		{
			get;
			set;
		}


	}
}
