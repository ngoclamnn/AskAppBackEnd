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
    public class PromotionsController : ApiController
    {
        private readonly IDiscountService _discountService;
        public PromotionsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public Promotion Get(int id)
        {
            return _discountService.GetPromotionById(id);
        }

        [HttpPost]
        public Promotion Create(Promotion entity)
        {
            entity.created = DateTime.Now;
            entity.modified = DateTime.Now;
            entity = _discountService.CreatePromotion(entity);
            _discountService.SavePromotion();
            return entity;
        }

        [HttpPut]
        public Promotion Update(Promotion entity)
        {
            entity.modified = DateTime.Now;
            entity = _discountService.UpdatePromotion(entity);
            _discountService.SavePromotion();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _discountService.DeletePromotion(id);
            _discountService.SavePromotion();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
