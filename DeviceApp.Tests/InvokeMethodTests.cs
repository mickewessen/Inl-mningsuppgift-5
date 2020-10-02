using SharedLibraries.Services;
using System;
using Xunit;
using Microsoft.Azure.Devices.Client;

namespace DeviceApp.Tests
{
    public class InvokeMethodTests
    {
        [Theory]
        [InlineData("uppgift5","SetInterval","5","200")]
        [InlineData("uppgift5", "GetInterval", "5", "501")]
        public void InvokeMethod(string targetDevice, string methodName, string payload, string expected)
        {
            var service = new ServiceClientService("HostName=ec-win-iothub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=C0CnL4iJd6QqKZMn7lOG0GdRChJHUbWPUEDbKaFPMEw=");
            var response = service.InvokeMethodAsync(targetDevice, methodName, payload);

            Assert.Equal(expected, response.Result.Status.ToString());
        }
    }
}
