using System.Collections.Generic;

namespace ServerFacades.Models
{
    public class TeamDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<int> ChampionshipYears { get; set; }
    }
}
