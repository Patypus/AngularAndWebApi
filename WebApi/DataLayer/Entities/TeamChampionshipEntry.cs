using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TeamChampionshipEntry
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ChampionshipYerId { get; set; }

        public Guid TeamId { get; set; }

        public virtual ChampionshipYear ChampionshipYear { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<DriverChampionshipEntry> DriverChampionshipEntries { get; set; }
    }
}
