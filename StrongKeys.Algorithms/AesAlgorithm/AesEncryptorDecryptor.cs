using StrongKeys.Common.Extensions;
using System;
using System.IO;
using System.Security.Cryptography;

namespace StrongKeys.Algotirhms.AesAlgorithm
{
    public class AesEncryptorDecryptor : IEncryptor, IDecryptor, IDisposable
    {
        readonly Aes _aes;

        public int KeySize
        {
            set
            {
                _aes.KeySize = value * 8;
            }
            get
            {
                return _aes.KeySize / 8;
            }
        }

        public AesEncryptorDecryptor(int keyLength = 32)
        {
            _aes = new AesManaged
            {
                Padding = PaddingMode.None,
                Mode = CipherMode.ECB
                //CipherMode.ECB
                //CipherMode.CBC
            };
            KeySize = keyLength;
        }

        public byte[] Encrypt(byte[] bytes, byte[] key, byte[] vector)
        {
            SetKeyVector(key, vector);
            return AESCryptBytes(bytes, true);
        }

        public byte[] Decrypt(byte[] bytes, byte[] key, byte[] vector)
        {
            SetKeyVector(key, vector);
            return AESCryptBytes(bytes, false);
        }

        byte[] AESCryptBytes(byte[] cryptBytes, bool encrypt)
        {
            byte[] clearBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, GetCryptoTransform(encrypt), CryptoStreamMode.Write))
                {
                    cs.Write(cryptBytes, 0, cryptBytes.Length);
                    cs.Close();
                }
                clearBytes = ms.ToArray();
            }

            return clearBytes;
        }

        ICryptoTransform GetCryptoTransform(bool encrypt)
        {
            return encrypt ? _aes.CreateEncryptor() : _aes.CreateDecryptor();
        }

        void SetKeyVector(byte[] key, byte[] vector)
        {
            _aes.Key = key.IncreaseTo(KeySize);
            _aes.IV = vector.IncreaseTo(16);
        }

        public void Dispose()
        {
            _aes?.Dispose();
        }
    }
}
