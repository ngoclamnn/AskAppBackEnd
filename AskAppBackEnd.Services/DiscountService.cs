using DiscountCrazyAdmin.Data;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Services
{
    public interface IDiscountService
    {
        Code GetCodeById(int id);
        CodeUsedHistory GetCodeUsedHistoryById(int id);
        DiscountType GetDiscountTypeById(int id);
        PromotionCode GetPromotionCodeById(int id);
        Promotion GetPromotionById(int id);
        Code CreateCode(Code entity);
        void SaveCode();
        Code UpdateCode(Code entity);
        void DeleteCode(int id);
        List<Code> CreateCodes(List<Code> entities);
        CodeUsedHistory CreateCodeUsedHistory(CodeUsedHistory entity);
        PromotionCode CreatePromotionCode(PromotionCode entity);
        void SaveCodeUsedHistory();
        Promotion CreatePromotion(Promotion entity);
        void SavePromotion();
        DiscountType CreateDiscountType(DiscountType entity);
        void SavePromotionCode();
        void SaveDiscountType();
        CodeUsedHistory UpdateCodeUsedHistory(CodeUsedHistory entity);
        Promotion UpdatePromotion(Promotion entity);
        PromotionCode UpdatePromotionCode(PromotionCode entity);
        void DeleteCodeUsedHistory(int id);
        DiscountType UpdateDiscountType(DiscountType entity);
        void DeletePromotion(int id);
        void DeleteDiscountType(int id);
        void DeletePromotionCode(int id);
    }

    public class DiscountService : IDiscountService
    {
        private readonly ICodeRepository _codeRepository;
        private readonly ICodeUsedHistoryRepository _codeUsedRepository;
        private readonly IDiscountTypesRepository _discountTypeRepository;
        private readonly IPromotionCodeRepository _promotionCodeRepository;
        private readonly IPromotionRepository _promotionRepository;

        public DiscountService(ICodeRepository codeRepository, ICodeUsedHistoryRepository codeUsedRepository,
            IDiscountTypesRepository discountTypeRepository, IPromotionCodeRepository promotionCodeRepository,
            IPromotionRepository promotionRepository)
        {
            _codeRepository = codeRepository;
            _codeUsedRepository = codeUsedRepository;
            _discountTypeRepository = discountTypeRepository;
            _promotionCodeRepository = promotionCodeRepository;
            _promotionRepository = promotionRepository;

        }
        public Code GetCodeById(int id)
        {
            return _codeRepository.GetById(id);
        }

        public CodeUsedHistory GetCodeUsedHistoryById(int id)
        {
            return _codeUsedRepository.GetById(id);
        }

        public DiscountType GetDiscountTypeById(int id)
        {
            return _discountTypeRepository.GetById(id);
        }

        public PromotionCode GetPromotionCodeById(int id)
        {
            return _promotionCodeRepository.GetById(id);
        }

        public Promotion GetPromotionById(int id)
        {
            return _promotionRepository.GetById(id);
        }

        public Code CreateCode(Code entity)
        {
            return _codeRepository.Insert(entity);
        }

        public List<Code> CreateCodes(List<Code> entities)
        {
            foreach (var code in entities)
            {
                _codeRepository.Insert(code);
            }
            return entities;
        }

        public void SaveCode()
        {
            _codeRepository.Save();
        }

        public Code UpdateCode(Code entity)
        {
            return _codeRepository.Insert(entity);
        }

        public void DeleteCode(int id)
        {
            var entityToRemove = new Code { id = id };
            _codeRepository.Delete(entityToRemove);
        }

        public CodeUsedHistory CreateCodeUsedHistory(CodeUsedHistory entity)
        {
            return _codeUsedRepository.Insert(entity);
        }

        public void SaveCodeUsedHistory()
        {
            _codeUsedRepository.Save();
        }

        public CodeUsedHistory UpdateCodeUsedHistory(CodeUsedHistory entity)
        {
            return _codeUsedRepository.Update(entity);
        }

        public void DeleteCodeUsedHistory(int id)
        {
            var entityToRemove = new CodeUsedHistory { id = id };
            _codeUsedRepository.Delete(entityToRemove);
        }

        public DiscountType CreateDiscountType(DiscountType entity)
        {
            return _discountTypeRepository.Insert(entity);
        }

        public void SaveDiscountType()
        {
            _discountTypeRepository.Save();
        }

        public DiscountType UpdateDiscountType(DiscountType entity)
        {
            return _discountTypeRepository.Update(entity);
        }

        public void DeleteDiscountType(int id)
        {
            var entityToRemove = new DiscountType { id = id };
            _discountTypeRepository.Delete(entityToRemove);
        }

        public PromotionCode CreatePromotionCode(PromotionCode entity)
        {
            return _promotionCodeRepository.Insert(entity);
        }

        public void SavePromotionCode()
        {
            _promotionCodeRepository.Save();
        }

        public PromotionCode UpdatePromotionCode(PromotionCode entity)
        {
            return _promotionCodeRepository.Update(entity);
        }

        public void DeletePromotionCode(int id)
        {
            var entityToDelete = new PromotionCode { id = id };
            _promotionCodeRepository.Delete(entityToDelete);
        }

        public Promotion CreatePromotion(Promotion entity)
        {
            return _promotionRepository.Insert(entity);
        }

        public void SavePromotion()
        {
             _promotionRepository.Save();
        }

        public Promotion UpdatePromotion(Promotion entity)
        {
            return _promotionRepository.Update(entity);
        }

        public void DeletePromotion(int id)
        {
            var entityToDelete = new Promotion { id = id };
            _promotionRepository.Delete(entityToDelete);
        }
    }
}
