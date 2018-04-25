using Ninject.Modules;
using StrongKeys.Common.Interfaces;
using StrongKeys.CryptoAdapter.AlgorithmsAdapters;

namespace StrongKeys.WebRunner.Modules
{
    public class CryptoModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICryptoTarget>().To<AesAdapter>();
        }
    }
}