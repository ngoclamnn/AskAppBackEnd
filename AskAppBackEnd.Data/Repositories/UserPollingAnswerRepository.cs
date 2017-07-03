using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserPollingAnswerRepository : Repository<UserPollingAnswer>, IUserPollingAnswerRepository
    {
        public UserPollingAnswerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserPollingAnswerRepository : IRepository<UserPollingAnswer>
    {
    }
}
