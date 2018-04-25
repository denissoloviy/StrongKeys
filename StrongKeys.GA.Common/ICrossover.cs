namespace StrongKeys.GA.Common
{
    public interface ICrossover
    {
        void ReplaceGenes(IChromosome chromosome, int startIndex, byte[] genes);
        IChromosome[] CrossoverChromosomes(IChromosome[] chromosomes, int count);
    }
}
