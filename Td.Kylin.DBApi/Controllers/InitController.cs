using Microsoft.AspNet.Mvc;
using Td.Kylin.DBApi.Data;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Td.Kylin.DBApi.Controllers
{
    [Route("api/init")]
    public class InitController : Controller
    {
        [HttpGet("apiauth")]
        public IActionResult InitApiModuleAuthorize()
        {
            int rows = InitProvider.InitApiMoudleAuthoriza();

            return Ok(string.Format("共初始化接口授权 {0} 项", rows));
        }
    }
}
