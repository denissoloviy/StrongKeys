using StrongKeys.Common.Interfaces;

namespace StrongKeys.CryptoAdapter
{
    public abstract class CryptoTarget : ICryptoTarget
    {
        public int KeyLength { get; private set; }
        protected CryptoTarget(int keyLength)
        {
            KeyLength = keyLength;
        }

        public abstract byte[] Decrypt(byte[] bytes, byte[] key);

        public abstract byte[] Encrypt(byte[] bytes, byte[] key);

        public abstract void Dispose();
    }
}
