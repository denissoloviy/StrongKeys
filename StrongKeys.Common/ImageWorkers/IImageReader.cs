using System.Drawing;

namespace StrongKeys.Common.ImageWorkers
{
    public interface IImageReader
    {
        byte[] GetArrayFromImage();
        Bitmap GetInitialBitmap();
        Bitmap GetBitmap(byte[] imageBytes);
    }
}
