using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserAnswerRepository : Repository<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserAnswerRepository : IRepository<UserAnswer>
    {

    }
}
