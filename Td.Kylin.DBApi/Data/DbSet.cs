using Microsoft.Data.Entity;
using Td.Kylin.Entity;

namespace Td.Kylin.DBCodeFirst
{
    public partial class DataContext
    {
        /// <summary>
        /// 模块授权
        /// </summary>
        public DbSet<System_ModuleAuthorize> System_ModuleAuthorize { get { return Set<System_ModuleAuthorize>(); } }
        
        /// <summary>
        /// 管理员
        /// </summary>
        public DbSet<Admin_Account> Admin_Account { get { return Set<Admin_Account>(); } }

        /// <summary>
        /// 商家所属行业
        /// </summary>
        public DbSet<Merchant_Industry> Merchant_Industry { get { return Set<Merchant_Industry>(); } }

        #region 平台提供的商家服务业务

        /// <summary>
        /// 平台提供的服务业务
        /// </summary>
        public DbSet<KylinService_Business> KylinService_Business { get { return Set<KylinService_Business>(); } }

        /// <summary>
        /// 平台服务业务子项
        /// </summary>
        public DbSet<KylinService_BusinessOptions> KylinService_BusinessOptions { get { return Set<KylinService_BusinessOptions>(); } }

        /// <summary>
        /// 平台服务价格配置
        /// </summary>
        public DbSet<KylinService_BusinessConfig> KylinService_BusinessConfig { get { return Set<KylinService_BusinessConfig>(); } }

        #endregion

        /// <summary>
        /// 全国区域
        /// </summary>
        public DbSet<System_Area> System_Area { get { return Set<System_Area>(); } }
    }
}
