using FleetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetMonitoring.Data.Repositories
{
    public interface IRoleRepository : IBaseRepository<Role>
    {

    }

    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
