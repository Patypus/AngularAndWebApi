using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class ChampionshipYear
    {
        [Key]
        public Guid Id { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Race> Races { get; set; }

        public virtual ICollection<TeamChampionshipEntry> TeamChampionshipEntrys { get; set; }
    }
}
