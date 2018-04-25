using Ninject.Modules;
using StrongKeys.Common.Configuration;
using StrongKeys.Common.Interfaces;
using StrongKeys.CryptoAdapter.AlgorithmsAdapters;

namespace StrongKeys.DesktopRunner
{
    class DesktopModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationManager>().To<WebConfigurationManager>().InSingletonScope();
            Bind<ICryptoTarget>().To<AesAdapter>();
            Bind<MainWindow>().ToSelf();
        }
    }
}
