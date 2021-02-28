using Microsoft.Extensions.Configuration;

namespace AzureFunctions.Api.Managers
{
    public class ConfigManager
    {
        public IConfigurationRoot Configurations { get; }

        public ConfigManager()
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("debug.settings.json",true)
                .Build();

            Configurations = config;
        }

        public string GetConfigValue(string Key)
        {
            string output = Configurations[Key];
            if (output == null)
            {
                output = Configurations["Values:" + Key];
            }
            return output;
        }

    }
}
