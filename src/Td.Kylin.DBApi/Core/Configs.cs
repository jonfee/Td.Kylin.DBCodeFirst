
namespace Td.Kylin.DBApi.Core
{
    /// <summary>
    /// 配置类
    /// </summary>
    public static class Configs
    {
        /// <summary>
        /// 服务区号
        /// </summary>
        public static uint District
        {
            get
            {
                return uint.Parse(Startup.Configuration["District"]);
            }
        }

        /// <summary>
        /// 平台号
        /// </summary>
        public static uint Platform
        {
            get
            {
                return uint.Parse(Startup.Configuration["Platform"]);
            }
        }
    }
}
