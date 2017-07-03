using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class AnswerOptionRepository : Repository<AnswerOption>, IAnswerOptionRepository
    {
        public AnswerOptionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IAnswerOptionRepository : IRepository<AnswerOption>
    {

    }
}
