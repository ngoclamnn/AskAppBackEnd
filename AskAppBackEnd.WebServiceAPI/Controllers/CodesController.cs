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
    public class CodesController : ApiController
    {
        private readonly IDiscountService _discountService;
        public CodesController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public Code Get(int id)
        {
            return _discountService.GetCodeById(id);
        }

        [Route("api/codes/createcode")]
        [HttpPost]
        public Code Create(Code entity)
        {
            entity.created = DateTime.Now;
            entity.modified = DateTime.Now;
            entity = _discountService.CreateCode(entity);
            _discountService.SaveCode();
            return entity;
        }

        [Route("api/codes/createcodes")]
        [HttpPost]
        public List<Code> CreateCodes(List<Code> entities)
        {
            entities = _discountService.CreateCodes(entities);
            _discountService.SaveCode();
            return entities;
        }

        [HttpPut]
        public Code Update(Code entity)
        {
            entity.modified = DateTime.Now;
            entity = _discountService.UpdateCode(entity);
            _discountService.SaveCode();
            return entity;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _discountService.DeleteCode(id);
            _discountService.SaveCode();
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}
