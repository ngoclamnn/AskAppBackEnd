using AskAppBackEnd.Data;
using AskAppBackEnd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskAppBackEnd.Services
{

    public interface IAskingService
    {
        IQueryable<AnswerOption> GetAnswerOptions();
        IQueryable<Question> GetQuestions();
        IQueryable<UserAnswer>  GetUserAnswers();
        IQueryable<UserPollingAnswer>  GetUserPollingAnswers();
        IQueryable<QuestionMedia>  GetQuestionMedias();

    }
    public class AskingService : IAskingService
    {
        private readonly IAnswerOptionRepository _answerOptionRepository;
        private readonly IQuestionMediaRepository _questionMediaRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IUserPollingAnswerRepository _userPollingAnswerRepository;
        public AskingService(IAnswerOptionRepository answerRepository, IQuestionMediaRepository questionMediaRepository,
            IQuestionRepository questionRepository, IUserAnswerRepository userAnswerRepository,
            IUserPollingAnswerRepository userPollingAnswerRepository)
        {

            _answerOptionRepository = answerRepository;
            _questionMediaRepository = questionMediaRepository;
            _questionRepository = questionRepository;
            _userAnswerRepository = userAnswerRepository;
            _userPollingAnswerRepository = userPollingAnswerRepository;
        }

        public IQueryable<AnswerOption> GetAnswerOptions()
        {
            return _answerOptionRepository.GetAll();
        }

        public IQueryable<Question> GetQuestions()
        {
            return _questionRepository.GetAll();
        }
        public IQueryable<UserAnswer> GetUserAnswers()
        {
            return _userAnswerRepository.GetAll();
        }
        public IQueryable<UserPollingAnswer> GetUserPollingAnswers()
        {
            return _userPollingAnswerRepository.GetAll();
        }
        public IQueryable<QuestionMedia> GetQuestionMedias()
        {
            return _questionMediaRepository.GetAll();
        }
    }
}
