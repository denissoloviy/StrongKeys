using Ninject;
using Ninject.Modules;
using StrongKeys.Common.Configuration;
using StrongKeys.DAL;

namespace StrongKeys.Service
{
    public class DBModule : NinjectModule
    {
        public override void Load()
        {
            var configurationManager = Kernel.Get<IConfigurationManager>();
            Bind<IDBContext>().To<MongoDBContext>()
                .WithConstructorArgument("connectionString", configurationManager.GetConnectionString("MongoConnection"))
                .WithConstructorArgument("dbName", configurationManager.GetAppSettings("MongoDBName"));
        }
    }
}
