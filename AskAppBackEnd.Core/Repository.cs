using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _dbset;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbContext _dbContext;
        public Repository(IUnitOfWork unitOfWork)
        {
            _dbset = unitOfWork.Set<T>();
            _unitOfWork = unitOfWork;
            _dbContext = unitOfWork.DbContext;
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }


        public IQueryable<T> GetAll()
        {
            return _dbset;
        }

        public T Insert(T entity)
        {
            return _dbset.Add(entity);
        }


        public T Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }


        public void Delete(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }


        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}
