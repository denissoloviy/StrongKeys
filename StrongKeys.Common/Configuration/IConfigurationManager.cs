namespace StrongKeys.Common.Configuration
{
    public interface IConfigurationManager
    {
        string GetConnectionString(string key);
        string GetAppSettings(string key);
    }
}
