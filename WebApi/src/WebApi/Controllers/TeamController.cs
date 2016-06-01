using Microsoft.AspNet.Mvc;
using System;
using ServerFacades.Facades.Interfaces;
using ServerFacades.Facades;

namespace WebApi.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamFacade _service;

        public TeamController()
        {
            _service = new TeamFacade();
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
