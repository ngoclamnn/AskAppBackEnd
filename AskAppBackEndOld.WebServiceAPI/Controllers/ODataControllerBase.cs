using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace AskAppBackEnd.Controllers
{
    [Authorize]
    public class ODataControllerBase<T> : ODataController where T : EntityBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<T> _dbSet;
        public ODataControllerBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbSet = _unitOfWork.Set<T>();
        }

        [EnableQuery]
        public IQueryable<T> Get()
        {
            return _dbSet.AsNoTracking();
        }

        public IHttpActionResult Post([FromBody] T entity)
        {
            try
            {
                entity.Id = Guid.NewGuid();
                _dbSet.Add(entity);
                _unitOfWork.Save();
                return Ok(entity);
            }
            catch (ArgumentNullException e)
            {
                return BadRequest();
            }
            catch (ArgumentException e)
            {
                return BadRequest();
            }
            catch (InvalidOperationException e)
            {
                return Conflict();
            }
        }

        public IHttpActionResult Put(Guid key, [FromBody] T entity)
        {
            try
            {
                entity.Id = key;
                _unitOfWork.DbContext.Entry(entity).State = EntityState.Modified;
                _unitOfWork.Save();
                return Ok(entity);
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch (ArgumentException)
            {
                return NotFound();
            }
        }

        public IHttpActionResult Delete(int key)
        {
            var entityRemove = _dbSet.Find(key);
            if (entityRemove != null)
                return Ok(_dbSet.Remove(entityRemove));
            else
                return NotFound();
        }
    }
}