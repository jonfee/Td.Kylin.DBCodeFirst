using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 跑腿订单评价。
	/// </summary>
	[Table("Legwork_Evaluate")]
	public class Legwork_Evaluate : BaseEntity
	{
		/// <summary>
		/// 评价ID。
		/// </summary>
		public long EvaluateID
		{
			get;
			set;
		}

		/// <summary>
		/// 订单ID。
		/// </summary>
		public long OrderID
		{
			get;
			set;
		}

		/// <summary>
		/// 用户ID。
		/// </summary>
		public long UserID
		{
			get;
			set;
		}

		/// <summary>
		/// 评价等级。
		/// </summary>
		public short Level
		{
			get;
			set;
		}

		/// <summary>
		/// 评价内容。
		/// </summary>
		[Column(TypeName = "nvarchar(200)")]
		public string Content
		{
			get;
			set;
		}

		/// <summary>
		/// 创建时间。
		/// </summary>
		public DateTime CreateTime
		{
			get;
			set;
		}
	}
}
