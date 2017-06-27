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
    public class DiscountTypesController : ApiController
    {
        private readonly IDiscountService _discountService;
        public DiscountTypesController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public DiscountType Get(int id)
        {
            return _discountService.GetDiscountTypeById(id);
        }

        [HttpPost]
        public DiscountType Create(DiscountType entity)
        {
            entity = _discountService.CreateDiscountType(entity);
            _discountService.SaveDiscountType();
            return entity;
        }

        [HttpPut]
        public DiscountType Update(DiscountType entity)
        {
            entity = _discountService.UpdateDiscountType(entity);
            _discountService.SaveDiscountType();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _discountService.DeleteDiscountType(id);
            _discountService.SaveDiscountType();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
