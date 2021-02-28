using AzureFunctions.Api;
using AzureFunctions.Api.Managers;
//using Microsoft.Azure.Functions.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(Startup))]
namespace AzureFunctions.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigManager _configManager = new ConfigManager();

            var services = builder.Services;
            
            services.AddSingleton(_configManager);
            services.BuildServiceProvider();
            
        }
    }

}
