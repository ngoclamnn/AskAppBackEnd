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
    public class UserResponsesController : ODataControllerBase<UserResponse>
    {
        private readonly IUserService _userService;
        public UserResponsesController(IUserService userService, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _userService = userService;
        }
    }
}
