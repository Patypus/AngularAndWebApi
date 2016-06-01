using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Track
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int LapLengthMeters { get; set; }

        public virtual ICollection<Race> Races { get; set; }
    }
}
