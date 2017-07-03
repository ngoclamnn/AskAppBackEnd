using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserNotificationRepository : Repository<UserNotification>, IUserNotificationRepository
    {
        public UserNotificationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserNotificationRepository : IRepository<UserNotification>
    {
    }
}
