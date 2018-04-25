using System;

namespace StrongKeys.Common.Interfaces
{
    public interface ICryptoTarget : IDecryptor, IEncryptor, IDisposable
    {
        int KeyLength { get; }
    }
}
