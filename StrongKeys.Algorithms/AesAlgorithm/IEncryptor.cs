namespace StrongKeys.Algotirhms.AesAlgorithm
{
    public interface IEncryptor
    {
        byte[] Encrypt(byte[] bytes, byte[] key, byte[] vector);
    }
}
