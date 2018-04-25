using StrongKeys.GA.Common;
using System;

namespace StrongKeys.GA.Generations
{
    class Generation : IGeneration
    {
        public int GenerationNumber { get; private set; }

        public DateTime CreationDate { get; private set; }

        public IChromosome[] Chromosomes { get; set; }

        public Generation(int generationNumber)
        {
            GenerationNumber = generationNumber;
            CreationDate = DateTime.UtcNow;
        }
    }
}
