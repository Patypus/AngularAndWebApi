using ServerFacades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Facades.Interfaces
{
    public interface ITeamsService
    {
        List<TeamDto> GetAllTeams();
    }
}
