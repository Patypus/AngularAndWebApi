using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        [HttpGet]
        public JsonResult GetAllTeamNames()
        {
            var dummyTeams = new List<SimpleTeamDetailsDto>
            {
            };

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
