using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class PromotionRepository : Repository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IPromotionRepository : IRepository<Promotion>
    {
    }
}
