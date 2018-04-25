using StrongKeys.Common.GAModels;
using StrongKeys.Common.Randomizations;
using StrongKeys.GA.Common;

namespace StrongKeys.GA.Chromosomes
{
    class Chromosome : IChromosome
    {
        public byte[] Key { get; set; }
        public byte[] Decrypted { get; set; }

        public FitnessValues FitnessValues { get; set; }

        private Chromosome() { }

        public Chromosome(int keyLength = 32)
        {
            Key = new byte[keyLength];
        }

        public IChromosome Clone()
        {
            return new Chromosome()
            {
                Key = Key
            };
        }

        public byte this[int index]
        {
            get
            {
                return Decrypted[index];
            }
        }
    }
}
