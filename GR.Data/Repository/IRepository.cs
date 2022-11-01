using Generic_Repository.Models;
using GR.Data.Models;

namespace Generic_Repository.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
    }
}
