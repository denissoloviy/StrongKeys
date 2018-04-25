using StrongKeys.Common.GAModels;
using System;

namespace StrongKeys.GA.Common
{
    public interface IPopulation
    {
        int KeySize { get; set; }
        DateTime CreationDate { get; }
        PopulationParameters PopulationParameters { get; }
        IGeneration CurrentGeneration { get; }
        void CreateInitialGeneration();
        void CreateNewGeneration(IChromosome[] chromosomes);
    }
}
