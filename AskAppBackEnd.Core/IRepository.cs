using System.Linq;

namespace DiscountCrazyAdmin.Core
{
    public interface IRepository<T>

    {

        T GetById(int id);

        IQueryable<T> GetAll();

        T Update(T entity);

        T Insert(T entity);

        void Delete(T entity);

        void Save();

    }
}