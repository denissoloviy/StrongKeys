using System;

namespace StrongKeys.WebRunner.Models.DTOs
{
    public class GenerationMinDTO
    {
        public int Id { get; set; }
        public int GenerationNumber { get; set; }
        public int PopulationId { get; set; }
        public DateTime CreationDate { get; set; }
        public ChromosomeMinDTO[] Chromosomes { get; set; }
    }
}