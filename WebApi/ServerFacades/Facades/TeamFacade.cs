using ServerFacades.Facades.Interfaces;
using ServerFacades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Facades
{
    public class TeamFacade : ITeamFacade
    {
        public List<TeamDto> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public List<SimpleTeamDetailsDto> GetTeamNames()
        {
            return new List<SimpleTeamDetailsDto>
            {
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Ferrari" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "McLaren" },
                new SimpleTeamDetailsDto { Id = new Guid(), Name = "Williams" }
            };
        }

        public TeamDto GetSingleTeamDetails(Guid teamId)
        {
            return new TeamDto
            {
                Id = new Guid(),
                ChampionshipYears = new List<int>(),
                Name = "dummy team"
            };
        }
    }
}
