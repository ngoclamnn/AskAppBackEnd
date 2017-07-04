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
    public class AnswerOptionsController : ODataController
    {
        private readonly IAskingService _askingService;
        public AnswerOptionsController(IAskingService askingService)
        {
            _askingService = askingService;
        }

        [EnableQuery]
        public IQueryable<AnswerOption> Get()
        {
            return _askingService.GetAnswerOptions();
        }
    }
}
