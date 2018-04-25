using MongoDB.Bson.Serialization.Attributes;
using StrongKeys.Common.GAModels;
using System;

namespace StrongKeys.DAL.Entities
{
    public class Population
    {
        [BsonId]
        public int Id { get; set; }
        public PopulationParameters PopulationParameters { get; set; }
        public DateTime CreationDate { get; set; }
        public ImageProperties OriginalImage { get; set; }
        public byte[] EncryptedImage { get; set; }
    }
}
