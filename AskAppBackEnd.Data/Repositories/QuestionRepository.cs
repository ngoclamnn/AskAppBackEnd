using AskAppBackEnd.Core;
using AskAppBackEnd.Data.Entities;


namespace AskAppBackEnd.Data
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

    public interface IQuestionRepository : IRepository<Question>
    {

    }
}
