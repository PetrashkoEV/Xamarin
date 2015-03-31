using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository.Private;
using SelfEducation.Business.Data.Services.Context.Private;
using SelfEducation.Business.Data.Services.Transaction.Private;

namespace SelfEducation.Business.Data.Services.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICreateTablesTransaction createTablesTransaction, ICreateDefaultTagsTransaction createDefaultTagsTransaction)
        {
            createTablesTransaction.Execute();
            createDefaultTagsTransaction.Execute();
        }

        public IConnectionExtensions Extension
        {
            get { return ServiceLocator.Current.GetInstance<IConnectionExtensions>(); }
        }

        public IRepository<CurrencyEntity> CurrencyRepository
        {
            get { return ServiceLocator.Current.GetInstance<IRepository<CurrencyEntity>>(); }
        }
    }
}