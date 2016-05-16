using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerFacades.Facades;
using ServerFacades.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        [HttpGet]
        public JsonResult GetAllTeamNames()
        {
            var dummy = new List<SimpleTeamDetailsDto>
            {
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Ferrari" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "McLaren" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Williams" }
            };

            return Json("success");
        }
    }
}
