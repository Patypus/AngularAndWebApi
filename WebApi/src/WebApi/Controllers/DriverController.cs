using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerFacades.Factory;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DriverController : Controller
    {
        private readonly IFacadeFactory _facades;

        public DriverController(IFacadeFactory factory)
        {
            _facades = factory;
        }

        [HttpGet]
        public JsonResult GetAllDriverRecords()
        {
            return Json("");
        }
    }
}
