namespace StrongKeys.Common.Randomizations
{
    public interface IRandomizer
    {
        double GetDouble();
        int GetInt(int max);
        int GetInt(int min, int max);
        byte GetByte();
        byte[] GetBytes(int length);
    }
}
