using System.Linq;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository.Private;
using SelfEducation.Business.Private;

namespace SelfEducation.Business.Service
{
    public class LogInService : ILogInService
    {
        private IRepository<CurrencyEntity> _repository;
        
        public LogInService(IRepository<CurrencyEntity> repository)
        {
            _repository = repository;
        }


        public int ReturnNum(int x)
        {
            var q = _repository.GetItems();
            var  w = q.ToList();
            return ++x;
        }
    }
}