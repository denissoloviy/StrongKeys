using StrongKeys.GA.Common;
using System.Linq;

namespace StrongKeys.GA.Selections
{
    public class Selector : ISelector
    {
        public IChromosome[] GetBestChromosomes(IChromosome[] chromosomes, int count)
        {
            return chromosomes
                .OrderByDescending(chromosome => chromosome.FitnessValues.MainCoef)
                .Take(count)
                .ToArray();
        }
    }
}
