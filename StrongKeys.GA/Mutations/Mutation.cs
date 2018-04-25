using StrongKeys.Common.Randomizations;
using StrongKeys.GA.Common;

namespace StrongKeys.GA.Mutations
{
    public class Mutation : IMutation
    {
        IRandomizer _randomizer;
        ICrossover _crossover;
        public Mutation(IRandomizer randomizer,
            ICrossover crossover)//TODO: Ninject
        {
            _randomizer = randomizer;
            _crossover = crossover;
        }

        public IChromosome[] Mutate(IChromosome[] chromosomes, double probability)
        {
            if (_randomizer.GetDouble() <= probability)
            {
                var chromosome = chromosomes[_randomizer.GetInt(chromosomes.Length)];
                Mutate(chromosome,
                    _randomizer.GetInt(chromosome.Key.Length),
                    _randomizer.GetInt(chromosome.Key.Length));
            }
            return chromosomes;
        }

        void Mutate(IChromosome chromosome, int startIndex, int count)
        {
            if (chromosome.Key.Length >= startIndex + count)
            {
                count = chromosome.Key.Length - startIndex;
            }

            var mutatedGenes = new byte[count];
            for (var i = 0; i < mutatedGenes.Length; i++)
            {
                mutatedGenes[i] = _randomizer.GetByte();
            }
            _crossover.ReplaceGenes(chromosome, startIndex, mutatedGenes);
        }
    }
}
