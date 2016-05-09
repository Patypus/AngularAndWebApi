using System.Collections.Generic;

namespace ServerFacades.Models
{
    public class DriverDto
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int RaceNumber { get; set; }

        public List<int> ChampionshipYears { get; set; }
    }
}
