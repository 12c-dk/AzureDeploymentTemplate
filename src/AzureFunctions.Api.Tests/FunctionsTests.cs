using AzureFunctions.Api.Managers;
using AzureFunctions.Api.Tests.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace AzureFunctions.Api.Tests
{
    public class FunctionsTests
    {
        private readonly ConfigManager _configManager;
        MockLogger<FunctionsTests> _mockLogger;

        public FunctionsTests(ITestOutputHelper output, ConfigManager configManager)
        {
            _mockLogger = new MockLogger<FunctionsTests>(output);
            _configManager = configManager;
        }

        [Fact]
        public void HttpTriggerTest()
        {
            _mockLogger.LogInformation("HttpTriggerTest started");

            var query = new Dictionary<String, StringValues>();
            var header = new Dictionary<String, StringValues>();
            string body = "";

            var req = HttpMock.HttpRequestSetup(header, query, body);

            var HttpTriggerFunc = new AzureFunctions.Api.Functions.HttpTrigger(_configManager);

            var result = HttpTriggerFunc.Run(req, _mockLogger).Result;

            OkObjectResult res = (OkObjectResult)result;

            string outputStr = res.Value.ToString();
            Assert.False(string.IsNullOrEmpty(res.Value.ToString()));
            Assert.Contains("Success", outputStr);


        }
    }
}
