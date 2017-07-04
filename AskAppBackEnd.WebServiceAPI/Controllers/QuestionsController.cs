using AskAppBackEnd.Data.Entities;
using AskAppBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace AskAppBackEnd.Controllers
{
    public class QuestionsController : ODataController
    {
        private readonly IAskingService _askingService;
        public QuestionsController(IAskingService askingService)
        {
            _askingService = askingService;
        }

        [EnableQuery]
        public IQueryable<Question> Get()
        {
            return _askingService.GetQuestions();
        }
    }
}
