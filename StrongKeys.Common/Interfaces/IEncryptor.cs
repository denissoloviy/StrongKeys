namespace StrongKeys.Common.Interfaces
{
    public interface IEncryptor
    {
        byte[] Encrypt(byte[] bytes, byte[] key);
    }
}
