namespace StrongKeys.Common.ImageWorkers
{
    public interface IImageWriter
    {
        void SaveArrayAsImage(string path, byte[] imageBytes);
    }
}
