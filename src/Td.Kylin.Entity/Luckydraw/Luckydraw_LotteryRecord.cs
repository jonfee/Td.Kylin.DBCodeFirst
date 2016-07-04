using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 抽奖记录表
	/// </summary>
	[Table("Luckydraw_LotteryRecord")]
	public class Luckydraw_LotteryRecord
	{
		/// <summary>
		///     记录ID，主键
		/// </summary>
		public long RecordID
		{
			get;
			set;
		}

		/// <summary>
		///     区域ID
		/// </summary>
		public int AreaID
		{
			get;
			set;
		}

		/// <summary>
		///     奖券ID
		/// </summary>
		public long TicketID
		{
			get;
			set;
		}

		/// <summary>
		///     用户ID
		/// </summary>
		public long UserID
		{
			get;
			set;
		}

		/// <summary>
		///     是否中奖
		/// </summary>
		public bool IsWinning
		{
			get;
			set;
		}

		/// <summary>
		///     收货信息(包括收货地址、电话等)
		/// </summary>
		[Column(TypeName = "nvarchar(200)")]
		public char ReceiptInfo
		{
			get;
			set;
		}

		/// <summary>
		///     是否发奖
		/// </summary>
		public bool IsDelivery
		{
			get;
			set;
		}

		/// <summary>
		///     发放人
		/// </summary>
		public long ConsignorID
		{
			get;
			set;
		}

		/// <summary>
		///     备注信息
		/// </summary>
		[Column(TypeName = "nvarchar(500)")]
		public char Remark
		{
			get;
			set;
		}

		/// <summary>
		///     创建时间
		/// </summary>
		public DateTime CreatedTime
		{
			get;
			set;
		}
	}
}