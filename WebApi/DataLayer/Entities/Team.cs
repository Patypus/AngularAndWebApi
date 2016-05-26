using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ColourFlash { get; set; }
    }
}
