using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserResponsRepository : Repository<UserResponse>, IUserResponsRepository
    {
        public UserResponsRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserResponsRepository : IRepository<UserResponse>
    {
    }
}
