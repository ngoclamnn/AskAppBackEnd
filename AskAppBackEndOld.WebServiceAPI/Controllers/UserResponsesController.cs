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
    public class UserResponsesController : ODataController
    {
        private readonly IUserService _userService;
        public UserResponsesController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableQuery]
        public IQueryable<UserResponse> Get()
        {
            return _userService.GetUserResponses();
        }
    }
}
