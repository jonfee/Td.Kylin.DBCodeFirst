using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 跑腿业务全局配置。
	/// </summary>
	[Table("Legwork_GlobalConfig")]
	public class Legwork_GlobalConfig : BaseEntity
    {
		/// <summary>
		/// 等待报价时间。
		/// </summary>
		public short QuotationWaitingTime
	    {
		    get;
		    set;
	    }

		/// <summary>
		/// 等待报价人数。
		/// </summary>
		public short QuotationWaitingWorkers
	    {
		    get;
		    set;
	    }

		/// <summary>
		/// 报价超时时间。
		/// </summary>
		public short QuotationWaitingTimeout
	    {
		    get;
		    set;
	    }

		/// <summary>
		/// 接单超时时间。
		/// </summary>
		public short OrderTimeout
	    {
		    get;
			set;
	    }

		/// <summary>
		/// 支付超时时间。
		/// </summary>
		public short PaymentTimeout
	    {
		    get;
		    set;
	    }

		/// <summary>
		/// 自动确认收货时间。
		/// </summary>
		public short AutoConfirmTime
	    {
		    get;
		    set;
	    }
    }
}