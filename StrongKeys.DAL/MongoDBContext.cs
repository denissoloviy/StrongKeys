using MongoDB.Bson;
using MongoDB.Driver;
using StrongKeys.DAL.Entities;
using StrongKeys.GA.Common;
using System.Linq;
using System.Collections.Generic;
using StrongKeys.Common.GAModels;

namespace StrongKeys.DAL
{
    public class MongoDBContext : IDBContext
    {
        IMongoDatabase _db;

        public MongoDBContext(string connectionString, string dbName)
        {
            var client = new MongoClient(connectionString);
            _db = client.GetDatabase(dbName);
        }

        public Population GetPopulation(int id)
        {
            return _db.GetCollection<Population>("Populations").Find(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Population> GetAllPopulations()
        {
            return _db.GetCollection<Population>("Populations").Find(x => true).ToEnumerable();
        }

        public IEnumerable<Generation> GetGenerations(int populationId, int startNumber, int count)
        {
            return _db.GetCollection<Generation>("Generations")
                .Find(x => x.PopulationId == populationId)
                .Skip(startNumber)
                .Limit(count)
                .ToEnumerable();
        }

        public long GetGenerationsCount(int populationId)
        {
            return _db.GetCollection<Generation>("Generations")
                .Find(x => true)
                .Count();
        }

        public void SaveGeneration(IGeneration generation, int populationId)
        {
            var collection = _db.GetCollection<Generation>("Generations");
            var count = 0;
            var gen = new Generation
            {
                Id = populationId + generation.GenerationNumber,
                GenerationNumber = generation.GenerationNumber,
                PopulationId = populationId,
                Chromosomes = generation.Chromosomes.Select(x => new Chromosome
                {
                    Id = count++,
                    Key = x.Key,
                    FitnessValues = x.FitnessValues
                }).ToArray(),
                CreationDate = generation.CreationDate
            };
            collection.InsertOne(gen);
        }

        public int SavePopulation(IPopulation population, ImageProperties originalImage, byte[] encryptedImage)
        {
            var collection = _db.GetCollection<Population>("Populations");
            var pop = new Population
            {
                CreationDate = population.CreationDate,
                Id = ObjectId.GenerateNewId().Increment,
                PopulationParameters = population.PopulationParameters,
                OriginalImage = originalImage,
                EncryptedImage = encryptedImage
            };
            collection.InsertOne(pop);
            return pop.Id;
        }
    }
}
