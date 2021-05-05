using FleetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetMonitoring.Data.Repositories
{
    public interface IOwnerRepository : IBaseRepository<Owner>
    {

    }

    public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
