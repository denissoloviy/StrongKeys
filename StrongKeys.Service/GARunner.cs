using StrongKeys.Common.GAModels;
using StrongKeys.Common.Interfaces;
using StrongKeys.GA;
using System.Threading.Tasks;

namespace StrongKeys.Service
{
    public class GARunner : IGARunner
    {
        private IGeneticAlgorithm _geneticAlgorithm;
        public ICryptoTarget Algorithm
        {
            set
            {
                _geneticAlgorithm.Algorithm = value;
            }
        }
        public ImageProperties OriginalImage
        {
            get { return _geneticAlgorithm.OriginalImage; }
            set
            {
                _geneticAlgorithm.OriginalImage = value;
            }
        }

        public byte[] EncryptedImage
        {
            get { return _geneticAlgorithm.EncryptedImage; }
            set
            {
                _geneticAlgorithm.EncryptedImage = value;
            }
        }

        public bool IsRunning => _geneticAlgorithm.IsRunning;

        public GARunner(IGeneticAlgorithm geneticAlgorithm)
        {
            _geneticAlgorithm = geneticAlgorithm;
        }

        public void Run()
        {
            Task.Run(() => _geneticAlgorithm.Run());
        }

        public void Pause()
        {
            _geneticAlgorithm.Pause();
        }

        public void Continue()
        {
            _geneticAlgorithm.Continue();
        }

        public void NextStep()
        {
            _geneticAlgorithm.NextStep();
        }

        public void Init()
        {
            _geneticAlgorithm.Init();
        }
    }
}
