using System;
using FleetMonitoring.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetMonitoring.Data.Persistance
{
    interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IOwnerRepository Owners { get; }
        IRoleRepository Roles { get; }
        IUnitRepository Units { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Roles = new RoleRepository(_context);
            Owners = new OwnerRepository(_context);
            Units = new UnitRepository(_context);
        }

        public IUserRepository Users { get; }
        public IOwnerRepository Owners { get; }
        public IRoleRepository Roles { get; }
        public IUnitRepository Units { get; }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
