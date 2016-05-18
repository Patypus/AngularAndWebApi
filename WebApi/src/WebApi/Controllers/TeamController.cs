using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerFacades.Facades;
using ServerFacades.Models;

namespace WebApi.Controllers
{
    public class TeamController : Controller
    {
        [HttpGet]
        [Route("api/team/getAllTeamNames")]
        public JsonResult GetAllTeamNames()
        {
            var dummy = new List<SimpleTeamDetailsDto>
            {
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Ferrari" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "McLaren" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Williams" }
            };

            return Json(dummy);
        }
    }
}
