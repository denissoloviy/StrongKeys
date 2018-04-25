using StrongKeys.Common.ImageWorkers;
using StrongKeys.CryptoAdapter;
using StrongKeys.CryptoAdapter.AlgorithmsAdapters;
using StrongKeys.GA;

namespace StrongKeys.ConsoleRunner
{
    class Program
    {
        static void Main()
        {
            //GeneticAlgorithm.Run();
            //using (CryptoTarget cryptor = new AesAdapter(16))
            //{
            //    var key = new byte[cryptor.KeyLength];
            //    for (byte i = 0; i < key.Length; i++)
            //    {
            //        key[i] = i;
            //    }
            //    using (var worker = new BitmapImageReaderWriter("1.png"))
            //    {
            //        var image = worker.GetArrayFromImage();
            //        var imageEnc = cryptor.Encrypt(image, key);

            //        worker.SaveArrayAsImage("1-enc.png", imageEnc);
            //    }

            //    using (var worker = new BitmapImageReaderWriter("1-enc.png"))
            //    {
            //        var image = worker.GetArrayFromImage();
            //        var imageDec = cryptor.Decrypt(image, key);

            //        worker.SaveArrayAsImage("1-dec.png", imageDec);
            //    }
            //}
        }
    }
}
