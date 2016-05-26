using Microsoft.AspNet.Mvc;
using System;
using ServerFacades.Facades.Interfaces;

namespace WebApi.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamsService _service;

        public TeamController()
        {
            _service = new TeamsService();
        }

        [HttpGet]
        [Route("api/team/getAllTeamNames")]
        public JsonResult GetAllTeamNames()
        {
            var allTeamNames = _service.GetTeamNames();

            return Json(allTeamNames);
        }

        [HttpGet]
        [Route("api/team/GetTeamDetails")]
        public JsonResult GetTeamDetails(Guid teamId)
        {
            var details = _service.GetSingleTeamDetails(teamId);

            return Json(details);
        }
    }
}
