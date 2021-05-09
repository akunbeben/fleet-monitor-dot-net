using System.Data.Entity;
using FleetMonitoring.Entity.Models;
using FleetMonitoring.Common;

namespace FleetMonitoring.Data
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base(WebUI.ConnectionString)
        {

        }

        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

    }
}
