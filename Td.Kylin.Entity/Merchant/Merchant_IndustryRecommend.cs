using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
	/// <summary>
	/// 商家所属行业推荐信息
	/// </summary>
	[Table("Merchant_IndustryRecommend")]
	public class Merchant_IndustryRecommend : BaseEntity
	{
		/// <summary>
		/// 区域ID
		/// </summary>
		public int AreaID
		{
			get; set;
		}

		///<summary>
		///行业ID
		///</summary>
		public long IndustryID
		{
			get; set;
		}

		///<summary>
		///排序
		///</summary>
		public int OrderNo
		{
			get; set;
		}
	}
}
