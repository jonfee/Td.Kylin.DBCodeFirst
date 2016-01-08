using Microsoft.AspNet.Mvc;
using Td.Kylin.DBApi.Data;
using Td.Kylin.WebApi;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Td.Kylin.DBApi.Controllers
{
    [Route("api/init")]
    public class InitController : BaseController
    {
        /// <summary>
        /// 初始化模块授权
        /// </summary>
        /// <returns></returns>
        [HttpGet("apiauth")]
        public IActionResult InitApiModuleAuthorize()
        {
            int rows = InitProvider.InitApiMoudleAuthoriza();

            return Ok(string.Format("共初始化接口授权 {0} 项", rows));
        }

        /// <summary>
        /// 初始化超级管理员
        /// </summary>
        /// <returns></returns>
        [HttpGet("superadmin")]
        public IActionResult InitSuperAdmin()
        {
            string account = "admin";

            string pwd = "123456";

            int rows = InitProvider.InitSuperAdmin(account, pwd);

            return Ok(string.Format("超级管理初始化成功！账号：{0}，密码：{1}", account, pwd));
        }

        [HttpGet("industry")]
        public IActionResult InitIndustry()
        {
            var result = InitProvider.InitIndustry();

            return KylinOk(result);
        }
    }
}
