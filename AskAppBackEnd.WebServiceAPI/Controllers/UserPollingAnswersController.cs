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
    public class UserPollingAnswersController : ODataController
    {
        private readonly IAskingService _askingService;
        public UserPollingAnswersController(IAskingService askingService)
        {
            _askingService = askingService;
        }

        [EnableQuery]
        public IQueryable<UserPollingAnswer> Get()
        {
            return _askingService.GetUserPollingAnswers();
        }
    }
}
