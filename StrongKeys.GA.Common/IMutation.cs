namespace StrongKeys.GA.Common
{
    public interface IMutation
    {
        IChromosome[] Mutate(IChromosome[] chromosomes, double probability);
    }
}
