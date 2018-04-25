using StrongKeys.Common.GAModels;
using StrongKeys.Common.Interfaces;
using StrongKeys.DAL;
using StrongKeys.GA.Common;

namespace StrongKeys.GA
{
    public class GeneticAlgorithm : IGeneticAlgorithm
    {
        readonly IPopulation _population;
        readonly IFitness _fitness;
        readonly ISelector _selector;
        readonly ICrossover _crossover;
        readonly IMutation _mutation;

        readonly IDBContext _db;

        int _populationId;
        ICryptoTarget _algorithm;
        public ICryptoTarget Algorithm
        {
            private get
            {
                return _algorithm;
            }
            set
            {
                _algorithm = value;
                _population.KeySize = _algorithm.KeyLength;
            }
        }

        public ImageProperties OriginalImage { get; set; }
        public byte[] EncryptedImage { get; set; }
        public bool IsRunning { get; private set; }

        public GeneticAlgorithm(IPopulation population,
            IFitness fitness,
            ISelector selector,
            ICrossover crossover,
            IMutation mutation,
            IDBContext db)
        {
            _population = population;
            _fitness = fitness;
            _selector = selector;
            _crossover = crossover;
            _mutation = mutation;

            _db = db;
        }

        public void Run()//TODO: add pause and stop methods
        {
            Initialize();
            Excecute();
        }

        public void Init()
        {
            Initialize();
        }

        public void NextStep()
        {
            Calculate();

            _db.SaveGeneration(_population.CurrentGeneration, _populationId);

            var newChromosomes = _selector.GetBestChromosomes(_population.CurrentGeneration.Chromosomes, _population.PopulationParameters.BestChromosomesCount);

            newChromosomes = _crossover.CrossoverChromosomes(newChromosomes, _population.PopulationParameters.ChromosomesCount);//TODO: randomChromosomesCount

            newChromosomes = _mutation.Mutate(newChromosomes, _population.PopulationParameters.MutationProbability);

            _population.CreateNewGeneration(newChromosomes);
        }

        public void Pause()
        {
            IsRunning = false;
        }

        public void Continue()
        {
            IsRunning = true;
            Excecute();
        }

        void Initialize()
        {
            IsRunning = true;
            _population.CreateInitialGeneration();
            _populationId = _db.SavePopulation(_population, OriginalImage, EncryptedImage);
        }

        void Excecute()
        {
            do
            {
                NextStep();
            }
            while (IsRunning);
        }

        void Calculate()
        {
            foreach (var chromosome in _population.CurrentGeneration.Chromosomes)
            {
                chromosome.Decrypted = _algorithm.Decrypt(OriginalImage.Image, chromosome.Key);

                _fitness.CalculateFitnessValues(chromosome, OriginalImage);
            }
        }
    }
}
