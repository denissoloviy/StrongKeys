using AutoMapper;
using Ninject.Modules;
using StrongKeys.Common.Configuration;
using StrongKeys.WebRunner.Helpers;

namespace StrongKeys.WebRunner.Modules
{
    public class WebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationManager>().To<WebConfigurationManager>().InSingletonScope();
            AutoMapperConfiguration.Configure();
            Bind<IMapper>().ToConstant(AutoMapper.Mapper.Instance).InSingletonScope();
        }
    }
}