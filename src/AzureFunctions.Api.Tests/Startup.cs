using AzureFunctions.Api.Managers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;

namespace AzureFunctions.Api.Tests
{
    class Startup
    {
        public delegate void LogRetryMessage(string messsage);

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            services.AddSingleton<ConfigManager>();

            var serviceProvider = services.BuildServiceProvider();

        }

        
    }
}
