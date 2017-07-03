using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class UserPreferenceRepository : Repository<UserPreference>, IUserPreferenceRepository
    {
        public UserPreferenceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IUserPreferenceRepository : IRepository<UserPreference>
    {
    }
}
