using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetMonitoring.Entity.Models
{
    [Table("Owner")]
    public class Owner : Base
    {
        [Key]
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}
