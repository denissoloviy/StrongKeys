using StrongKeys.Common.Interfaces;

namespace StrongKeys.GA
{
    public interface IGeneticAlgorithm : IGAImage
    {
        ICryptoTarget Algorithm { set; }
        bool IsRunning { get; }
        void Run();
        void Pause();
        void Continue();
        void NextStep();
        void Init();
    }
}
