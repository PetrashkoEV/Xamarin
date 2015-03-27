using Autofac;
using SelfEducation.Business.Data.Repository;
using SelfEducation.Business.Data.Repository.Private;
using SelfEducation.Business.Data.Services.Context;
using SelfEducation.Business.Data.Services.Context.Private;
using SelfEducation.Business.Data.Services.Transaction;
using SelfEducation.Business.Data.Services.Transaction.Private;

namespace SelfEducation.Business.Data
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterType<ConnectionExtensions>().As<IConnectionExtensions>();

            //transaction
            builder.RegisterType<CreateDefaultTagsTransaction>().As<ICreateDefaultTagsTransaction>();
            builder.RegisterType<CreateTablesTransaction>().As<ICreateTablesTransaction>();
        }
    }
}