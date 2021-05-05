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
    }
}
