using System;
using System.Collections.Generic;

namespace ServerFacades.Models
{
    public class TeamDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<int> ChampionshipYears { get; set; }
    }
}
