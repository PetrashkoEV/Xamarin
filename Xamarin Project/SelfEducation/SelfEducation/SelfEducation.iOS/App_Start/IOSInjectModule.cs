using Autofac;

namespace SelfEducation.iOS
{
    public class IosInjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<SQLitePlatformAndroid>().As<ISQLitePlatform>();
        }
    }
}