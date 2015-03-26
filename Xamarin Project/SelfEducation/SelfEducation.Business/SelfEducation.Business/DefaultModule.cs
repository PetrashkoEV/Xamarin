using Autofac;
using SelfEducation.Business.Data.Entities;
using SelfEducation.Business.Data.Repository;
using SelfEducation.Business.Data.Repository.Private;
using SelfEducation.Business.Private;
using SelfEducation.Business.Service;

namespace SelfEducation.Business
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // register repository
            builder.RegisterType<Repository<CurrencyEntity>>().As<IRepository<CurrencyEntity>>();

            builder.RegisterType<LogInService>().As<ILogInService>();
        }
    }
}