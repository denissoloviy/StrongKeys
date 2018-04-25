using System.Configuration;

namespace StrongKeys.Common.Configuration
{
    public class WebConfigurationManager : IConfigurationManager
    {
        public string GetAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
