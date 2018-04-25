using StrongKeys.Common.GAModels;

namespace StrongKeys.Common.Interfaces
{
    public interface IGAImage
    {
        ImageProperties OriginalImage { get; set; }
        byte[] EncryptedImage { get; set; }
    }
}
