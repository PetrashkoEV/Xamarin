using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository.Private;

namespace SelfEducation.Business.Data.Services.Context.Private
{
    public interface IUnitOfWork
    {
        IConnectionExtensions Extension { get; }
        IRepository<CurrencyEntity> CurrencyRepository { get; }
    }
}