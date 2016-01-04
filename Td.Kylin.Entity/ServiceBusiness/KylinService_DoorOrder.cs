using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.ServiceBusiness
{
    /// <summary>
    /// 上门/预约订单
    /// </summary>
    [Table("KylinService_Order", Schema = "dbo")]
    public class KylinService_Order
    {
        public long OrderID { get; set; }
        
    }
}
