using Ninject;
using Ninject.Modules;
using StrongKeys.Common.Configuration;
using StrongKeys.Common.GAModels;
using StrongKeys.Common.Randomizations;
using StrongKeys.DAL;
using StrongKeys.GA;
using StrongKeys.GA.Common;
using StrongKeys.GA.Crossovers;
using StrongKeys.GA.Fitnesses;
using StrongKeys.GA.Generations;
using StrongKeys.GA.Mutations;
using StrongKeys.GA.Populations;
using StrongKeys.GA.Selections;

namespace StrongKeys.Service
{
    public class GAModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGARunner>().To<GARunner>().InSingletonScope();
            Bind<IGeneticAlgorithm>().To<GeneticAlgorithm>().InSingletonScope();

            Bind<IPopulation>().To<Population>()
                .InSingletonScope()
                .WithConstructorArgument("populationParameters", new PopulationParameters(10, 5, 2, 0.5f));
            Bind<IFitness>().To<Fitness>().InSingletonScope();
            Bind<ISelector>().To<Selector>().InSingletonScope();
            Bind<ICrossover>().To<Crossover>().InSingletonScope();
            Bind<IMutation>().To<Mutation>().InSingletonScope();
            Bind<IRandomizer>().To<Randomizer>().InSingletonScope();
            Bind<IChromosomeGenerator>().To<ChromosomesGenerator>().InSingletonScope();
        }
    }
}
