using Autofac;
using SelfEducation.Business.Private;
using SelfEducation.Business.Service;

namespace SelfEducation.Business
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // register Service
            builder.RegisterType<LogInService>().As<ILogInService>();
        }
    }
}