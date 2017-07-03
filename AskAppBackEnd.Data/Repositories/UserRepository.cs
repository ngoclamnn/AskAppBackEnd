using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}
