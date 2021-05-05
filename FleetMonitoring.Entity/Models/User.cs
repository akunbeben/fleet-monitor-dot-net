using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetMonitoring.Entity.Models
{
    [Table("User")]
    public class User : Base
    {
        [Key]
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
