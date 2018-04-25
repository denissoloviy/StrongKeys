using System;

namespace StrongKeys.Common.Extensions
{
    public static class ByteExtensions
    {
        public static byte[] IncreaseTo(this byte[] value, int count)
        {
            if (value.Length == count)
            {
                return value;
            }
            var tempArr = new byte[count];
            for (int i = 0; i < tempArr.Length; i += value.Length)
            {
                Array.Copy(value, 0, tempArr, i, tempArr.Length - i > value.Length ? value.Length : tempArr.Length - i);
            }
            return tempArr;
        }
        public static bool DeviationEquals(this byte number1, byte number2, byte deviation)
        {
            return (number2 >= number1 - deviation && number2 <= number1 - deviation);
        }
    }
}
