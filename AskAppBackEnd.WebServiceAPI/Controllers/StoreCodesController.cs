using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiscountCrazyAdmin.Controllers
{
    public class StoreCodesController : ApiController
    {
        public StoreCodesController()
        {
        }
        public StoreCode Get(int id)
        {
            return new StoreCode();
        }
    }
}
