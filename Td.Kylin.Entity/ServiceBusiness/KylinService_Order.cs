using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.Entity.ServiceBusiness
{
    /// <summary>
    /// 上门订单
    /// </summary>
    [Table("KylinService_DoorOrder", Schema = "dbo")]
    public class KylinService_DoorOrder
    {
        public long OrderID { get; set; }


    }
}
