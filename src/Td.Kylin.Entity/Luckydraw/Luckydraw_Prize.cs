using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	///     奖品表
	/// </summary>
	[Table("Luckydraw_Prize")]
	public class Luckydraw_Prize
	{
		/// <summary>
		///     奖品ID，主键
		/// </summary>
		public long PrizeID
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
		///     奖品名称
		/// </summary>
		[Column(TypeName = "nvarchar(50)")]
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		///     奖品图片
		/// </summary>
		[Column(TypeName = "varchar(200)")]
		public string CoverImage
		{
			get;
			set;
		}

		/// <summary>
		///     奖品价值
		/// </summary>
		public decimal Denomination
		{
			get;
			set;
		}

		/// <summary>
		///     奖品数量
		/// </summary>
		public int Quantity
		{
			get;
			set;
		}

		/// <summary>
		///     奖品剩余数量,
		/// </summary>
		public int Balance
		{
			get;
			set;
		}

		/// <summary>
		///     通用券生成数量
		/// </summary>
		public int GlobalTicketBuildCount
		{
			get;
			set;
		}

		/// <summary>
		///     奖品券生成数量
		/// </summary>
		public int PrizeTicketBuildCount
		{
			get;
			set;
		}

		/// <summary>
		///     有效时间(起)
		/// </summary>
		public DateTime StartTime
		{
			get;
			set;
		}

		/// <summary>
		///     有效时间(止)
		/// </summary>
		public DateTime EndTime
		{
			get;
			set;
		}

		/// <summary>
		///     奖品描述
		/// </summary>
		[Column(TypeName ="nvarchar(MAX)")]
		public string Introduction
		{
			get;
			set;
		}

		/// <summary>
		///     是否发布
		/// </summary>
		public bool IsPublished
		{
			get;
			set;
		}

		/// <summary>
		///     发布时间
		/// </summary>
		public DateTime PublishedTime
		{
			get;
			set;
		}

		/// <summary>
		///     排列顺序
		/// </summary>
		public int SortOrder
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


		/// <summary>
		///     更新时间
		/// </summary>
		public DateTime UpdatedTime
		{
			get;
			set;
		}


		/// <summary>
		///     是否删除
		/// </summary>
		public bool IsDelete
		{
			get;
			set;
		}
		/// <summary>
		/// 通用券剩余数量
		/// </summary>
		public int GlobalTicketBalance
		{
			get;
			set;
		}
		/// <summary>
		/// 奖品券剩余数量
		/// </summary>
		public int PrizeTicketBalance
		{
			get;
			set;
		}
	}
}