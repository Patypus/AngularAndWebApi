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

        [HttpGet]
        [Route("api/team/GetTeamDetails")]
        public JsonResult GetTeamDetails(Guid teamId)
        {
            var details = new TeamDto
            {
                Id = new Guid(),
                ChampionshipYears = new List<int>(),
                Name = "dummy team"
            };

            return Json(details);
        }
    }
}
