using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class BusinessCategoryRepository : Repository<BusinessCategory>, IBusinessCategoryRepository
    {
        public BusinessCategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IBusinessCategoryRepository : IRepository<BusinessCategory>
    {

    }
}
