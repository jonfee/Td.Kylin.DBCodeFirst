using Microsoft.Data.Entity;
using Td.Kylin.Entity;

namespace Td.Kylin.DBCodeFirst
{
    public partial class DataContext
    {
        #region 模块授权

        /// <summary>
        /// 模块授权
        /// </summary>
        public DbSet<System_ModuleAuthorize> System_ModuleAuthorize { get { return Set<System_ModuleAuthorize>(); } }

        #endregion
    }
}
