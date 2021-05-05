using System.Data.Entity;
using FleetMonitoring.Entity.Models;

namespace FleetMonitoring.Data
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("FleetConnection")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

    }
}
