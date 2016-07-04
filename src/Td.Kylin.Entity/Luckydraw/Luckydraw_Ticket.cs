using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 奖券表
	/// </summary>
	[Table("Luckydraw_Ticket")]
	public class Luckydraw_Ticket
    {
		/// <summary>
		/// 奖券ID，主键
		/// </summary>
		public long TicketID
		{
			get;
			set;
		}
		/// <summary>
		/// 区域ID
		/// </summary>
		public int AreaID
		{
			get;
			set;
		}

		/// <summary>
		/// 奖券编号
		/// </summary>
		[Column(TypeName = "varchar(50)")]
		public char TicketCode
		{
			get;
			set;
		}

		/// <summary>
		/// 奖券类型，引用 Luckydraw_TicketType 枚举
		/// </summary>
		public short Type
		{
			get;
			set;
		}

		/// <summary>
		///  	奖品ID，引用 Luckydraw_Prize 表
		/// </summary>
		public long PrizeID
		{
			get;
			set;
		}

		/// <summary>
		/// 有效时间(起)
		/// </summary>
		public DateTime StartTime
		{
			get;
			set;
		}

		/// <summary>
		/// 有效时间(止)
		/// </summary>
		public DateTime EndTime
		{
			get;
			set;
		}
		/// <summary>
		/// 获得用户ID
		/// </summary>
		public long UserID
		{
			get;
			set;
		}
		/// <summary>
		///  	获得时间
		/// </summary>
		public DateTime AcquiredTime
		{
			get;
			set;
		}

		/// <summary>
		/// 是否使用(1:已使用 0:未使用)
		/// </summary>
		public bool IsUsed
		{
			get;
			set;
		}

		/// <summary>
		/// 使用时间
		/// </summary>
		public DateTime UsedTime
		{
			get;
			set;
		}
		/// <summary>
		/// 是否中奖
		/// </summary>
		public bool IsWinning
		{
			get;
			set;
		}
		
	}
}
