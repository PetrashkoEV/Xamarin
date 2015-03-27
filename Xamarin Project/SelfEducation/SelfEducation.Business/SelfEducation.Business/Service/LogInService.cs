using System.Linq;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Services.Context.Private;
using SelfEducation.Business.Private;

namespace SelfEducation.Business.Service
{
    public class LogInService : ILogInService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public LogInService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public int ReturnNum(int x)
        {
            var select = _unitOfWork.Extension.QueryAsync<CurrencyEntity>("SELECT * FROM CurrencyEntity");
            var q = select.Result.ToList();

            return ++x;
        }
    }
}