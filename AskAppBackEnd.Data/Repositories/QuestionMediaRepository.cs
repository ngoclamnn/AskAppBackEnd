using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Data
{
    public class QuestionMediaRepository : Repository<QuestionMedia>, IQuestionMediaRepository
    {
        public QuestionMediaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IQuestionMediaRepository : IRepository<QuestionMedia>
    {
    }
}
