using StrongKeys.Common.Interfaces;

namespace StrongKeys.Service
{
    public interface IGARunner : IGAImage
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
