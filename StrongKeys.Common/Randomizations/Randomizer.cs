using System;

namespace StrongKeys.Common.Randomizations
{
    public sealed class Randomizer : IRandomizer
    {
        static Random _random;
        //static readonly object _syncRoot = new Object();

        public Randomizer()
        {
            _random = new Random(DateTime.Now.Millisecond);
        }

        public byte[] GetBytes(int length)
        {
            var bytes = new byte[length];
            _random.NextBytes(bytes);
            return bytes;
        }

        public byte GetByte()
        {
            return (byte)GetInt(0, 255);
        }

        public double GetDouble()
        {
            return _random.NextDouble();
        }

        public int GetInt(int min, int max)
        {
            var result = 0;
            result = _random.Next(min, max);
            return result;
        }

        public int GetInt(int max)
        {
            return GetInt(0, max);
        }
    }
}
