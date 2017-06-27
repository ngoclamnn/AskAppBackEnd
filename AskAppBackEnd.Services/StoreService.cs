using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountCrazyAdmin.Data.Entities;
using DiscountCrazyAdmin.Data;

namespace DiscountCrazyAdmin.Services
{
    public interface IStoreService
    {
        Store GetStoreById(int id);
    }

    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public Store GetStoreById(int id)
        {
            return _storeRepository.GetById(id);
        }
    }
}
