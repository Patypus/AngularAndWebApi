using Microsoft.AspNet.Mvc;
using System;
using ServerFacades.Facades.Interfaces;
using ServerFacades.Facades;
using ServerFacades.Factory;

namespace WebApi.Controllers
{
    public class TeamController : Controller
    {
        private readonly IFacadeFactory _facades;

        public TeamController(IFacadeFactory factory)
        {
            _facades = factory;
        }

        [HttpGet]
        [Route("api/team/getAllTeamNames")]
        public JsonResult GetAllTeamNames()
        {
            var allTeamNames = _facades.TeamFacade().GetTeamNames();

            return Json(allTeamNames);
        }

        [HttpGet]
        [Route("api/team/GetTeamDetails")]
        public JsonResult GetTeamDetails(Guid teamId)
        {
            var details = _facades.TeamFacade().GetSingleTeamDetails(teamId);

            return Json(details);
        }
    }
}
