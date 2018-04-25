using StrongKeys.Common.GAModels;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StrongKeys.Common.ImageWorkers
{
    public class BitmapImageReaderWriter : IImageReader, IImageWriter, IDisposable
    {
        readonly PixelFormat pixelFormat = PixelFormat.Format24bppRgb;
        readonly Bitmap _bitmap;
        public int Width { get { return _bitmap.Width; } }
        public int Height { get { return _bitmap.Height; } }

        public BitmapImageReaderWriter(string path)
        {
            using (var bitmap = new Bitmap(path))
            {
                _bitmap = new Bitmap(bitmap.Width, bitmap.Height, pixelFormat);
                using (var gr = Graphics.FromImage(_bitmap))
                {
                    gr.DrawImage(bitmap, new Rectangle(0, 0, _bitmap.Width, _bitmap.Height));
                }
            }
        }

        private BitmapImageReaderWriter(int width, int height)
        {
            _bitmap = new Bitmap(width, height, pixelFormat);
        }

        public static byte[] GetBitmapBytes(ImageProperties image)
        {
            using (var worker = new BitmapImageReaderWriter(image.Width, image.Height))
            {
                var bitmap = worker.GetBitmap(image.Image);
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public byte[] GetArrayFromImage()
        {
            var bmpData = _bitmap.LockBits(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), ImageLockMode.ReadWrite, _bitmap.PixelFormat);
            var bytes = GetBytesCount(bmpData.Stride);

            var rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, rgbValues, 0, bytes);

            _bitmap.UnlockBits(bmpData);
            return rgbValues;
        }

        public Bitmap GetBitmap(byte[] imageBytes)
        {
            var bitmap = _bitmap.Clone(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), _bitmap.PixelFormat);
            var bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
            var bytes = GetBytesCount(bmpData.Stride);

            System.Runtime.InteropServices.Marshal.Copy(imageBytes, 0, bmpData.Scan0, bytes);
            bitmap.UnlockBits(bmpData);
            return bitmap;
        }

        public Bitmap GetInitialBitmap()
        {
            return _bitmap.Clone(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), _bitmap.PixelFormat);
        }

        public void SaveArrayAsImage(string path, byte[] imageBytes)
        {
            var bmpData = _bitmap.LockBits(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), ImageLockMode.ReadWrite, _bitmap.PixelFormat);
            int bytes = GetBytesCount(bmpData.Stride);

            System.Runtime.InteropServices.Marshal.Copy(imageBytes, 0, bmpData.Scan0, bytes);

            _bitmap.UnlockBits(bmpData);
            _bitmap.Save(path);
        }

        int GetBytesCount(int stride)
        {
            return Math.Abs(stride) * _bitmap.Height;
        }

        public void Dispose()
        {
            _bitmap?.Dispose();
        }
    }
}
