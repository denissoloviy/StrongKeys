using StrongKeys.Common.GAModels;

namespace StrongKeys.GA.Common
{
    public interface IChromosome : IChromosomeKey, IChromosomeResult, IChromosomeFitness, IClonableChromosome { }

    public interface IChromosomeKey
    {
        byte[] Key { get; set; }
    }

    public interface IChromosomeResult
    {
        byte[] Decrypted { get; set; }
        byte this[int index] { get; }
    }

    public interface IChromosomeFitness
    {
        FitnessValues FitnessValues { get; set; }
    }

    public interface IClonableChromosome
    {
        IChromosome Clone();
    }
}
