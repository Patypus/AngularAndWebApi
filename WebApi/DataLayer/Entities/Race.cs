using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Race
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime RaceDate { get; set; }

        public string RaceName { get; set; }

        public Guid TrackId { get; set; }

        public virtual Track Track { get; set; }

        public virtual ICollection<RaceResultPosition> RaceResultPositions { get; set; }
    }
}
