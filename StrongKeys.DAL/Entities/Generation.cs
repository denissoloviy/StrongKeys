using MongoDB.Bson.Serialization.Attributes;
using System;

namespace StrongKeys.DAL.Entities
{
    public class Generation
    {
        [BsonId]
        public int Id { get; set; }
        public int GenerationNumber { get; set; }
        public int PopulationId { get; set; }
        public DateTime CreationDate { get; set; }
        public Chromosome[] Chromosomes { get; set; }
    }
}
