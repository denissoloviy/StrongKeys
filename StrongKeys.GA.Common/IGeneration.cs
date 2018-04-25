using System;

namespace StrongKeys.GA.Common
{
    public interface IGeneration
    {
        int GenerationNumber { get; }
        DateTime CreationDate { get; }
        IChromosome[] Chromosomes { get; set; }
    }
}
