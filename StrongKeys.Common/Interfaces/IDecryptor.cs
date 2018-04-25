namespace StrongKeys.Common.Interfaces
{
    public interface IDecryptor
    {
        byte[] Decrypt(byte[] bytes, byte[] key);
    }
}
