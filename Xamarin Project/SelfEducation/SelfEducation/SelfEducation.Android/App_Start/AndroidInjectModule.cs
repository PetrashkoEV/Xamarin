using Autofac;
using SelfEducation.Business.Data.Contracts.Private;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;

namespace SelfEducation.Android
{
    public class AndroidInjectModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AndroidDbLocation>().As<IDbLocation>();
            builder.RegisterType<SQLitePlatformAndroid>().As<ISQLitePlatform>();
        }
    }
}