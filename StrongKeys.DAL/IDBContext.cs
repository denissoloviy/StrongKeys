using StrongKeys.Common.GAModels;
using StrongKeys.DAL.Entities;
using StrongKeys.GA.Common;
using System.Collections.Generic;

namespace StrongKeys.DAL
{
    public interface IDBContext
    {
        int SavePopulation(IPopulation population, ImageProperties originalImage, byte[] encryptedImage);
        void SaveGeneration(IGeneration generation, int populationId);
        IEnumerable<Population> GetAllPopulations();
        Population GetPopulation(int id);
        long GetGenerationsCount(int populationId);
        IEnumerable<Generation> GetGenerations(int populationId, int startNumber, int count);
    }
}
