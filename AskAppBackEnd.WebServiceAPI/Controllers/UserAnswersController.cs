using AskAppBackEnd.Core;
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
    [Authorize]
    public class UserAnswersController : ODataControllerBase<UserAnswer>
    {
        private readonly IAskingService _askingService;
        public UserAnswersController(IAskingService askingService, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _askingService = askingService;
        }
    }
}
