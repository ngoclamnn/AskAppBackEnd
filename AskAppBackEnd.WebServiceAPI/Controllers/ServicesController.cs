using DiscountCrazyAdmin.Data.Entities;
using DiscountCrazyAdmin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiscountCrazyAdmin.Controllers
{
    public class ServicesController : ApiController
    {
        private readonly IStoreService _storeService;
        public ServicesController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        public Store Get(int id)
        {
            return _storeService.GetStoreById(id);
        }
    }
}
