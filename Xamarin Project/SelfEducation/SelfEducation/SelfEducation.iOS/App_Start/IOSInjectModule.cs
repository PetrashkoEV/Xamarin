using Autofac;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;

namespace SelfEducation.iOS
{
    public class IosInjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SQLitePlatformIOS>().As<ISQLitePlatform>();
        }
    }
}