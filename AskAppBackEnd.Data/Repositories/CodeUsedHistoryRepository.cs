using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Data
{
    public class CodeUsedHistoryRepository : Repository<CodeUsedHistory>, ICodeUsedHistoryRepository
    {
        public CodeUsedHistoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface ICodeUsedHistoryRepository : IRepository<CodeUsedHistory>
    {
    }
}
