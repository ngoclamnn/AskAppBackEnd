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
    public class UserFriendsController : ODataController
    {
        private readonly IUserService _userService;
        public UserFriendsController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableQuery]
        public IQueryable<UserFriend> Get()
        {
            return _userService.GetUserFriends();
        }
    }
}
