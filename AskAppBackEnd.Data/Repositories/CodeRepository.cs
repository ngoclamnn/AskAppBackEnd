using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data.Entities;


namespace DiscountCrazyAdmin.Data
{
    public class CodeRepository : Repository<Code>, ICodeRepository
    {
        public CodeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface ICodeRepository : IRepository<Code>
    {

    }
}
