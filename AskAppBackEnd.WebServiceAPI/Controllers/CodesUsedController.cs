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
    public class CodesUsedController : ApiController
    {
        private readonly IDiscountService _discountService;
        public CodesUsedController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public CodeUsedHistory Get(int id)
        {
            return _discountService.GetCodeUsedHistoryById(id);
        }

        [HttpPost]
        public CodeUsedHistory Create(CodeUsedHistory entity)
        {
            entity.created = DateTime.Now;
            entity.modified = DateTime.Now;
            entity = _discountService.CreateCodeUsedHistory(entity);
            _discountService.SaveCodeUsedHistory();
            return entity;
        }

        [HttpPut]
        public CodeUsedHistory Update(CodeUsedHistory entity)
        {
            entity.modified = DateTime.Now;
            entity = _discountService.UpdateCodeUsedHistory(entity);
            _discountService.SaveCodeUsedHistory();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _discountService.DeleteCodeUsedHistory(id);
            _discountService.SaveCodeUsedHistory();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
