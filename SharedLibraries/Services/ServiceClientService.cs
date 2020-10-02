using System;
using System.Threading.Tasks;
using Microsoft.Azure.Devices;

namespace SharedLibraries.Services
{
    public class ServiceClientService
    {
        private static ServiceClient serviceClient;


        public ServiceClientService(string connectionstring)
        {
            serviceClient = ServiceClient.CreateFromConnectionString("HostName=ec-win-iothub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=C0CnL4iJd6QqKZMn7lOG0GdRChJHUbWPUEDbKaFPMEw=");
        }

        public async Task<CloudToDeviceMethodResult> InvokeMethodAsync(string targetDevice, string methodName, string payload)
        {
            var methodInvocation = new CloudToDeviceMethod(methodName);
            methodInvocation.SetPayloadJson(payload);

            var response = await serviceClient.InvokeDeviceMethodAsync(targetDevice, methodInvocation);
            return response;

        }


    }
}