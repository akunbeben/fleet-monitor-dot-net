using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FleetMonitoring.Data.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity Get(int id);
        TEntity Save(TEntity entity);
        TEntity Update(int id, TEntity entity);
        void Delete(int id);
    }

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDBContext _context;

        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(int id, TEntity entity)
        {
            if (entity == null)
                return null;

            TEntity current = Get(id);

            if (current == null)
                return null;

            _context.Entry(current).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            return current;
        }

        public void Delete(int id)
        {
            TEntity current = Get(id);

            if (current == null)
                return;

            _context.Set<TEntity>().Remove(current);
            _context.SaveChanges();
        }
    }
}
