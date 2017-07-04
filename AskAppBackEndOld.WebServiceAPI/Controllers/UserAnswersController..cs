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
    public class UserAnswersController : ODataController
    {
        private readonly IAskingService _askingService;
        public UserAnswersController(IAskingService askingService)
        {
            _askingService = askingService;
        }

        [EnableQuery]
        public IQueryable<UserAnswer> Get()
        {
            return _askingService.GetUserAnswers();
        }
    }
}
