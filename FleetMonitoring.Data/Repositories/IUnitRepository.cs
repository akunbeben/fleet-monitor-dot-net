using FleetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetMonitoring.Data.Repositories
{
    public interface IUnitRepository : IBaseRepository<Unit>
    {

    }

    public class UnitRepository : BaseRepository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
