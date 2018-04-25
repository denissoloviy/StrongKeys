using StrongKeys.Common.GAModels;

namespace StrongKeys.GA.Common
{
    public interface IFitness
    {
        void CalculateFitnessValues(IChromosome chromosome, ImageProperties OriginalImage);
    }
}
