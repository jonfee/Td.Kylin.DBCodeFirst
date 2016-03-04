using System.ComponentModel.DataAnnotations;

namespace Td.Kylin.Entity
{
    /// <summary>
    /// 数据模型实体基类
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 行版本
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
     