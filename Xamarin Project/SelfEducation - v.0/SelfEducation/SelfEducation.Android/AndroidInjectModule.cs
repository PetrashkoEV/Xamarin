using Autofac;

namespace SelfEducation.Android
{
    public class AndroidInjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<SQLitePlatformAndroid>().As<ISQLitePlatform>();
        }
    }
}