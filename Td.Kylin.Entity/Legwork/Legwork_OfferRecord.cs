using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 跑腿报价记录。
	/// </summary>
	[Table("Legwork_OfferRecord")]
	public class Legwork_OfferRecord : BaseEntity
	{
		/// <summary>
		/// 报价ID。
		/// </summary>
		public long OfferID
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
		/// 费用。
		/// </summary>
		public decimal Charge
		{
			get;
			set;
		}

		/// <summary>
		/// 服务员ID。
		/// </summary>
		public long WorkerID
		{
			get;
			set;
		}

		/// <summary>
		/// 服务员所在经度。
		/// </summary>
		public Single Longitude
		{
			get;
			set;
		}

		/// <summary>
		/// 服务员所在纬度。
		/// </summary>
		public Single Latitude
		{
			get;
			set;
		}

		/// <summary>
		/// 是否被采用。
		/// </summary>
		public bool IsUsed
		{
			get;
			set;
		}

		/// <summary>
		/// 记录创建时间。
		/// </summary>
		public DateTime CreateTime
		{
			get;
			set;
		}
	}
}