using StrongKeys.Common.Randomizations;
using StrongKeys.GA.Common;
using System.Linq;

namespace StrongKeys.GA.Crossovers
{
    public class Crossover : ICrossover
    {
        IRandomizer _randomizer;
        public Crossover(IRandomizer randomizer)//TODO: Ninject
        {
            _randomizer = randomizer;
        }
        public IChromosome[] CrossoverChromosomes(IChromosome[] chromosomes, int count)
        {
            var result = new IChromosome[count];
            for (var i = 0; i < count; i++)
            {
                var firstChromosome = chromosomes[_randomizer.GetInt(chromosomes.Length)].Clone();
                var secondChromosome = chromosomes[_randomizer.GetInt(chromosomes.Length)];

                var startIndex = _randomizer.GetInt(firstChromosome.Key.Length);
                ReplaceGenes(firstChromosome,
                    startIndex,
                    secondChromosome.Key.Where((x, index) => index > startIndex).ToArray());

                result[i] = firstChromosome;
            }

            return result;
        }

        public void ReplaceGenes(IChromosome chromosome, int startIndex, byte[] genes)
        {
            for (var i = startIndex; i < genes.Length && i < chromosome.Key.Length; i++)
            {
                chromosome.Key[i] = genes[i - startIndex];
            }
        }
    }
}
