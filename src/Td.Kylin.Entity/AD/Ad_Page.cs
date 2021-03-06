﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 广告页面
    /// </summary>
    [Table("Ad_Page")]
    public class Ad_Page
    {
        ///<summary>
        ///广告页ID
        ///</summary>
        public long PageID { get; set; }

        ///<summary>
        ///所属平台（客户端、商家端、员工端）
        ///</summary>
        [Column(TypeName ="int")]
        public int PlatformType { get; set; }

        ///<summary>
        ///页面名称
        ///</summary>
        [Column(TypeName = "nvarchar(20)")]
        public string PageName { get; set; }

    }
}
