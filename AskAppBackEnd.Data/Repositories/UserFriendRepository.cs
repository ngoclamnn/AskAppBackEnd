using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserFriendRepository : Repository<UserFriend>, IUserFriendRepository
    {
        public UserFriendRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserFriendRepository : IRepository<UserFriend>
    {
    }
}
