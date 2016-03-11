using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Td.Kylin.DBApi.Data.PostgreSql
{
    public class User
    {
        public long UserID { get; set; }

        public int Age { get; set; }

        public byte Sex { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public bool IsVip { get; set; }

        public DateTime CreateTime { get; set; }

        [Timestamp]
        public DateTime RowVersion { get; set; }
    }
}
