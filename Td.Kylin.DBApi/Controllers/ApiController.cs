using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Td.Kylin.WebApi;
using Td.Common;
using Td.Kylin.EnumLibrary;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Td.Kylin.DBApi.Controllers
{
    [Route("api/[controller]")]
    public class ApiController : BaseController
    {
        // GET: api/values
        [HttpGet("test")]
        public IActionResult Test()
        {
            string err = EnumUtility.GetEnumDescription<ResultCode>(ResultCode.DataException.ToString());
            return Error(EnumLibrary.ResultCode.DataException, err);
        }
    }
}
