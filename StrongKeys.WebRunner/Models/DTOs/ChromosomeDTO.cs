using StrongKeys.Common.GAModels;

namespace StrongKeys.WebRunner.Models.DTOs
{
    public class ChromosomeDTO
    {
        public int Id { get; set; }
        public byte[] Key { get; set; }
        public byte[] DecryptedImage { get; set; }
        public FitnessValues FitnessValues { get; set; }
    }
}