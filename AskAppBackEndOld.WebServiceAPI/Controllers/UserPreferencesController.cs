﻿using AskAppBackEnd.Data.Entities;
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
    public class UserPreferencesController : ODataController
    {
        private readonly IUserService _userService;
        public UserPreferencesController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableQuery]
        public IQueryable<UserPreference> Get()
        {
            return _userService.GetUserPreferences();
        }
    }
}
