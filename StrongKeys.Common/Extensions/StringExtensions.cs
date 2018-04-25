using System.Text;

namespace StrongKeys.Common.Extensions
{
    public static class StringExtensions
    {
        public static byte[] ConvertToBytes(this string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }
    }
}
