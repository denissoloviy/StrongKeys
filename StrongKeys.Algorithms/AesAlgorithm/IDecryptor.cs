namespace StrongKeys.Algotirhms.AesAlgorithm
{
    public interface IDecryptor
    {
        byte[] Decrypt(byte[] bytes, byte[] key, byte[] vector);
    }
}
