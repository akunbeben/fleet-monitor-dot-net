using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetMonitoring.Entity.Models;

namespace FleetMonitoring.Data.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {

    }

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
