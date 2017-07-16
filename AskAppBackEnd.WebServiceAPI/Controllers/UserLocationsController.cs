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
    public class UserLocationsController : ODataController
    {
        private readonly IUserService _userService;
        public UserLocationsController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableQuery]
        public IQueryable<UserLocation> Get()
        {
            return _userService.GetUserLocations();
        }
    }
}
