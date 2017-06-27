using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class PromotionCodeRepository : Repository<PromotionCode>, IPromotionCodeRepository
    {
        public PromotionCodeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IPromotionCodeRepository : IRepository<PromotionCode>
    {
    }
}
