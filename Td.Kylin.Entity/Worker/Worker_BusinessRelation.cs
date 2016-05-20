using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 服务职员业务关联表。
	/// </summary>
	[Table("Worker_BusinessRelation")]
	public class Worker_BusinessRelation : BaseEntity
	{
		///<summary>
		/// 服务职员ID。
		///</summary>
		public long WorkerID
		{
			get;
			set;
		}

		/// <summary>
		/// 业务类型。
		/// </summary>
		public short BusinessType
		{
			get;
			set;
		}

		/// <summary>
		/// 审核状态。
		/// </summary>
		public short AuditStatus
		{
			get;
			set;
		}

		/// <summary>
		/// 审核的管理员ID。
		/// </summary>
		public long? AuditAdminID
		{
			get;
			set;
		}

		/// <summary>
		/// 审核的管理员名称。
		/// </summary>
		[Column(TypeName = "nvarchar(20)")]
		public string AudtiAdminName
		{
			get;
			set;
		}

		/// <summary>
		/// 审核备注说明。
		/// </summary>
		[Column(TypeName = "nvarchar(300)")]
		public string AuditRemark
		{
			get;
			set;
		}

		/// <summary>
		/// 服务开通时间（为null表示未开通线上业务）。
		/// </summary>
		[Column(TypeName = "datetime")]public DateTime? OpenServiceTime
		{
			get;
			set;
		}

		/// <summary>
		/// 数据创建时间。
		/// </summary>
		[Column(TypeName = "datetime")]public DateTime CreateTime
		{
			get;
			set;
		}
	}
}