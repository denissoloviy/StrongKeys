namespace StrongKeys.Common.Extensions
{
    public static class IntExtensions
    {
        public static bool DeviationEquals(this int number1, int number2, int deviation)
        {
            return (number2 >= number1 - deviation && number2 <= number1 - deviation);
        }
    }
}
