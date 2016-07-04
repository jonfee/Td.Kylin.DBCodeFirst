using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 奖池表
	/// </summary>
	[Table("Luckydraw_PrizePool")]
	public class Luckydraw_PrizePool
	{
		/// <summary>
		///     记录ID，主键
		/// </summary>
		public long ID
		{
			get;
			set;
		}

		/// <summary>
		///     区域ID
		/// </summary>
		public long AreaID
		{
			get;
			set;
		}

		/// <summary>
		///   奖品ID
		/// </summary>
		public long PrizeID
		{
			get;
			set;
		}

		///释放时间
		/// <summary>
		/// </summary>
		public DateTime ReleaseTime
		{
			get;
			set;
		}

		/// <summary>
		///     剩余数
		/// </summary>
		public int Balance
		{
			get;
			set;
		}
	}
}