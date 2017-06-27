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
    public class PromotionCodesController : ApiController
    {
        private readonly IDiscountService _discountService;

        public PromotionCodesController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public PromotionCode Get(int id)
        {
            return _discountService.GetPromotionCodeById(id);
        }

        [HttpPost]
        public PromotionCode Create(PromotionCode entity)
        {
            entity = _discountService.CreatePromotionCode(entity);
            _discountService.SavePromotionCode();
            return entity;
        }

        [HttpPut]
        public PromotionCode Update(PromotionCode entity)
        {
            entity = _discountService.UpdatePromotionCode(entity);
            _discountService.SavePromotionCode();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _discountService.DeletePromotionCode(id);
            _discountService.SavePromotionCode();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
