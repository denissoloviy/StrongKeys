using StrongKeys.Common.Randomizations;
using StrongKeys.GA.Chromosomes;
using StrongKeys.GA.Common;

namespace StrongKeys.GA.Generations
{
    public class ChromosomesGenerator : IChromosomeGenerator
    {
        private IRandomizer _randomizer;
        public ChromosomesGenerator(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }
        public IChromosome GenerateChromosome(int keySize = 32)
        {
            return new Chromosome(keySize)
            {
                Key = _randomizer.GetBytes(keySize)
            };
        }

        public IChromosome[] GenerateChromosomes(int count, int keySize = 32)
        {
            var Chromosomes = new IChromosome[count];
            for (var i = 0; i < Chromosomes.Length; i++)
            {
                Chromosomes[i] = new Chromosome(keySize)
                {
                    Key = _randomizer.GetBytes(keySize)
                };//TODO Ninject
            }

            return Chromosomes;
        }
    }
}
