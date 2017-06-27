using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class DiscountTypesRepository : Repository<DiscountType>, IDiscountTypesRepository
    {
        public DiscountTypesRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IDiscountTypesRepository : IRepository<DiscountType>
    {
    }
}
