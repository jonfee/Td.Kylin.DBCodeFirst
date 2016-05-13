using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 跑腿业务物品类型。
	/// </summary>
	[Table("Legwork_GoodsCategory")]
	public class Legwork_GoodsCategory : BaseEntity
	{
		/// <summary>
		/// 分类ID。
		/// </summary>
		public long CategoryID
		{
			get;
			set;
		}

		/// <summary>
		/// 分类名称。
		/// </summary>
		[Column(TypeName = "nvarchar(20)")]
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// 排列顺序。
		/// </summary>
		public int SortOrder
		{
			get;
			set;
		}

		/// <summary>
		/// 是否删除。
		/// </summary>
		public bool IsDelete
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
