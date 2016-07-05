using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 区域派券规则
	/// </summary>
	[Table("Luckydraw_AreaTicketGivingRules")]
	public class Luckydraw_AreaTicketGivingRules
	{
		/// <summary>
		///     主键：区域ID
		/// </summary>
		public int AreaID
		{
			get;
			set;
		}

		/// <summary>
		///     主键：派券规则，引用 Luckydraw_TicketGivingRules 枚举
		/// </summary>
		public short Rule
		{
			get;
			set;
		}

		/// <summary>
		///     规则值
		/// </summary>
		[Column(TypeName = "varchar(200)")]
		public string Values
		{
			get;
			set;
		}
		
		/// <summary>
		///     奖券数量
		/// </summary>
		public short Quantity
		{
			get;
			set;
		}

		/// <summary>
		///     是否启用
		/// </summary>
		public bool IsEnabled
		{
			get;
			set;
		}
	}
}