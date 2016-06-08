using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class DriverChampionshipEntry
    {
        [Key]
        public Guid Id { get; set; }

        public Guid TeamChampionshipEntryId { get; set; }

        public Guid DriverId { get; set; }

        public virtual TeamChampionshipEntry TeamChampionshipEntry { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
