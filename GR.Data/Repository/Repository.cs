using Generic_Repository.Models;
using GR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> entities;
        public Repository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
            entities=_context.Set<T>();
        }

        public T Get(int id)
        {
            var entity = entities.FirstOrDefault(e => e.Id == id);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
         return entities.AsEnumerable();
        }

        public void insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void update(T entity)
        {
            throw new NotImplementedException();
        }
        public void delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
