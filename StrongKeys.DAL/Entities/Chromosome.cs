using MongoDB.Bson.Serialization.Attributes;
using StrongKeys.Common.GAModels;

namespace StrongKeys.DAL.Entities
{
    public class Chromosome
    {
        [BsonId]
        public int Id { get; set; }
        public byte[] Key { get; set; }
        public FitnessValues FitnessValues { get; set; }
    }
}
