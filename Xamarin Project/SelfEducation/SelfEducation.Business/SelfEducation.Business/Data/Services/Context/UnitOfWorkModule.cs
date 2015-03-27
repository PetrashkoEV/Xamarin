using Autofac;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository;
using SelfEducation.Business.Data.Repository.Private;

namespace SelfEducation.Business.Data.Services.Context
{
    public class UnitOfWorkModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // register repository
            builder.RegisterType<Repository<CurrencyEntity>>().As<IRepository<CurrencyEntity>>();
        }
    }
}