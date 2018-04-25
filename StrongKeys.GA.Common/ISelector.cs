namespace StrongKeys.GA.Common
{
    public interface ISelector
    {
        IChromosome[] GetBestChromosomes(IChromosome[] chromosomes, int count);
    }
}
