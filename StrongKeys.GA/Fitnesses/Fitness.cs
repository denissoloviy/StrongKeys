using StrongKeys.Common.Extensions;
using StrongKeys.Common.GAModels;
using StrongKeys.GA.Common;
using System;

namespace StrongKeys.GA.Fitnesses
{
    public class Fitness : IFitness
    {
        byte deviation = 10;
        public void CalculateFitnessValues(IChromosome chromosome, ImageProperties OriginalImage)
        {
            int r = 0, g = 0, b = 0, approximate = 0, direct = 0, length = chromosome.Decrypted.Length;
            for (var i = 0; i < length; i += 3)
            {
                bool tempR = false, tempG = false, tempB = false;
                if (chromosome.Decrypted[i].DeviationEquals(OriginalImage.Image[i], deviation))
                {
                    tempR = true;
                    r++;
                }
                if (chromosome.Decrypted[i + 1].DeviationEquals(OriginalImage.Image[i + 1], deviation))
                {
                    tempG = true;
                    g++;
                }
                if (chromosome.Decrypted[i + 2].DeviationEquals(OriginalImage.Image[i + 2], deviation))
                {
                    tempB = true;
                    b++;
                }
                if (tempR && tempG && tempB)
                {
                    approximate++;
                }
                if (chromosome.Decrypted[i] == OriginalImage.Image[i] &&
                    chromosome.Decrypted[i + 1] == OriginalImage.Image[i + 1] &&
                    chromosome.Decrypted[i + 2] == OriginalImage.Image[i + 2])
                {
                    direct++;
                }
            }
            var doubleLength = Convert.ToDouble(length);
            chromosome.FitnessValues = new FitnessValues(Convert.ToDouble(direct) / doubleLength,
                Convert.ToDouble(approximate) / doubleLength,
                Convert.ToDouble(r) / doubleLength,
                Convert.ToDouble(g) / doubleLength,
                Convert.ToDouble(b) / doubleLength);
        }
    }
}
