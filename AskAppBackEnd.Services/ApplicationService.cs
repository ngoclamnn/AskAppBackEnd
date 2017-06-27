using DiscountCrazyAdmin.Data;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly IBusinessCategoryRepository _businessCategoryRepository;
        public ApplicationService(IBusinessCategoryRepository businessCategoryRepository)
        {
            _businessCategoryRepository = businessCategoryRepository;
        }

        public BusinessCategory GetBusinessCategoryById(int businessCategoryId)
        {
            return _businessCategoryRepository.GetById(businessCategoryId);
        }

        public BusinessCategory CreateBusinessCategory(BusinessCategory businessCategory)
        {
            return _businessCategoryRepository.Insert(businessCategory);
        }


        public BusinessCategory UpdateBusinessCategory(BusinessCategory businessCategory)
        {
            return _businessCategoryRepository.Update(businessCategory);
        }

        public void DeleteBusinessCategory(int id)
        {
            var entityToRemove = new BusinessCategory { id = id };
            _businessCategoryRepository.Delete(entityToRemove);
        }

        public void SaveBusinessCategory()
        {
            _businessCategoryRepository.Save();
        }
    }

    public interface IApplicationService
    {
        BusinessCategory GetBusinessCategoryById(int businessCategoryId);
        void DeleteBusinessCategory(int id);
        BusinessCategory CreateBusinessCategory(BusinessCategory businessCategory);
        BusinessCategory UpdateBusinessCategory(BusinessCategory businessCategory);
        void SaveBusinessCategory();
    }
}
