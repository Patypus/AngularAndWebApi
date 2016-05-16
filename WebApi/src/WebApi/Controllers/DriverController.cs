using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DriverController : Controller
    {
        [HttpGet]
        public JsonResult GetAllDriverRecords()
        {
            return Json("");
        }
    }
}
