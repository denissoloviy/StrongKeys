namespace StrongKeys.Common.GAModels
{
    public class PopulationParameters
    {
        public int ChromosomesCount { get; set; }
        public int BestChromosomesCount { get; set; }
        public int RandomChromosomesCount { get; set; }
        public float MutationProbability { get; set; }

        public PopulationParameters(int chromosomesCount, int bestChromosomesCount, int randomChromosomesCount = 2, float mutationProbability = 0.2f)
        {
            ChromosomesCount = chromosomesCount;
            BestChromosomesCount = bestChromosomesCount;
            RandomChromosomesCount = randomChromosomesCount;
            MutationProbability = mutationProbability;
        }
    }
}
