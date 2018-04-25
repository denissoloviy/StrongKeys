using StrongKeys.Algotirhms.AesAlgorithm;

namespace StrongKeys.CryptoAdapter.AlgorithmsAdapters
{
    public class AesAdapter : CryptoTarget
    {
        readonly AesEncryptorDecryptor _aesEncryptorDecryptor;
        readonly byte[] _vector;

        public AesAdapter(int keyLength = 32) : base(keyLength)
        {
            _vector = new byte[KeyLength];
            _aesEncryptorDecryptor = new AesEncryptorDecryptor(KeyLength);
        }

        public override byte[] Decrypt(byte[] bytes, byte[] key)
        {
            return _aesEncryptorDecryptor.Decrypt(bytes, key, _vector);
        }

        public override byte[] Encrypt(byte[] bytes, byte[] key)
        {
            return _aesEncryptorDecryptor.Encrypt(bytes, key, _vector);
        }

        public override void Dispose()
        {
            _aesEncryptorDecryptor?.Dispose();
        }
    }
}
