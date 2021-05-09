using FleetMonitoring.Entity.Models;
using System;

namespace FleetMonitoring.Data.Repositories
{
    public interface IOwnerRepository : IBaseRepository<Owner>, IDisposable
    {

    }

    public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDBContext context) : base(context)
        {

        }

        public override Owner Update(int id, Owner entity)
        {
            var current = base.Get(id);

            if (current == null)
                return null;

            current.Name = entity.Name;
            current.UpdatedAt = entity.UpdatedAt;

            _context.SaveChanges();

            return current;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
