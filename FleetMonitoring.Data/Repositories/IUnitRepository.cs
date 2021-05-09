using FleetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FleetMonitoring.Data.Repositories
{
    public interface IUnitRepository : IBaseRepository<Unit>, IDisposable
    {

    }

    public class UnitRepository : BaseRepository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDBContext context) : base(context)
        {

        }

        public override Unit Get(int id)
        {
            return _context.Set<Unit>().Include("Owner").FirstOrDefault(entity => entity.UnitId == id);
        }

        public override IEnumerable<Unit> GetAll()
        {
            return _context.Set<Unit>().Include("Owner").ToList();
        }

        public override Unit Update(int id, Unit entity)
        {
            var current = base.Get(id);

            if (current == null)
                return null;

            current.Identity = entity.Identity;
            current.Name = entity.Name;
            current.Description = entity.Description;
            current.OwnerId = entity.OwnerId;
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
