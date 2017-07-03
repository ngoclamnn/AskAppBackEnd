using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserLocationRepository : Repository<UserLocation>, IUserLocationRepository
    {
        public UserLocationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserLocationRepository : IRepository<UserLocation>
    {
    }
}
