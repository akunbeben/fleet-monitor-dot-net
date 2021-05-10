using System.Data.Entity;
using FleetMonitoring.Entity.Models;
using FleetMonitoring.Common;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace FleetMonitoring.Data
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext() : base(WebUI.ConnectionString, throwIfV1Schema: false)
        {

        }

        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }

        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

    }
}
