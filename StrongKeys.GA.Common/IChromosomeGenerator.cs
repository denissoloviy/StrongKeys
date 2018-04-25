namespace StrongKeys.GA.Common
{
    public interface IChromosomeGenerator
    {
        IChromosome[] GenerateChromosomes(int count, int keySize = 32);
        IChromosome GenerateChromosome(int keySize = 32);
    }
}
