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
    public class UserNotificationsController : ODataController
    {
        private readonly IUserService _userService;
        public UserNotificationsController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableQuery]
        public IQueryable<UserNotification> Get()
        {
            return _userService.GetUserNotifications();
        }
    }
}
