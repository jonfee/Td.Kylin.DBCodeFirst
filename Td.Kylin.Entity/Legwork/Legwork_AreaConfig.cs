using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 跑腿业务区域配置。
	/// </summary>
	[Table("Legwork_AreaConfig")]
	public class Legwork_AreaConfig : BaseEntity
	{
		/// <summary>
		/// 区域ID。
		/// </summary>
		public int AreaID
		{
			get;
			set;
		}

		/// <summary>
		/// 业务须知。
		/// </summary>
		[Column(TypeName = "nvarchar(5000)")]
		public string Instructions
		{
			get;
			set;
		}

		/// <summary>
		/// 开通跑腿业务的行政区域。
		/// </summary>
		[Column(TypeName = "varchar(100)")]
		public string OpenAreas
		{
			get;
			set;
		}
	}
}
