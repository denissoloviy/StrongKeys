using StrongKeys.Common.GAModels;
using StrongKeys.GA.Common;
using StrongKeys.GA.Generations;
using System;

namespace StrongKeys.GA.Populations
{
    public class Population : IPopulation
    {
        IChromosomeGenerator _generator;
        public Population(IChromosomeGenerator generator, PopulationParameters populationParameters)
        {
            _generator = generator;
            PopulationParameters = populationParameters;
            CreationDate = DateTime.UtcNow;
        }

        public PopulationParameters PopulationParameters { get; private set; }
        public DateTime CreationDate { get; private set; }

        public IGeneration CurrentGeneration { get; private set; }
        public int KeySize { get; set; }

        public void CreateInitialGeneration()
        {
            CurrentGeneration = new Generation(1)
            {
                Chromosomes = _generator.GenerateChromosomes(PopulationParameters.ChromosomesCount, KeySize)
            };//TODO Ninject, investigate if we can save generation number in NinjectModule scope
        }

        public void CreateNewGeneration(IChromosome[] chromosomes)
        {
            CurrentGeneration = new Generation(CurrentGeneration.GenerationNumber + 1)
            {
                Chromosomes = chromosomes
            };
        }
    }
}
