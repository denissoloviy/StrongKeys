using StrongKeys.Common.GAModels;
using System;
using System.Web.Mvc;

namespace StrongKeys.WebRunner.Models.DTOs
{
    public class PopulationDTO
    {
        public int Id { get; set; }
        public PopulationParameters PopulationParameters { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] OriginalImage { get; set; }
        public byte[] EncryptedImage { get; set; }
    }
}
