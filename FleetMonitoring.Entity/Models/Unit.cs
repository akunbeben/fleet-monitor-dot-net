using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetMonitoring.Entity.Models
{
    [Table("Unit")]
    public class Unit : Base
    {
        [Key]
        public int UnitId { get; set; }

        public string Identity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int OwnerId { get; set; }
    }
}
