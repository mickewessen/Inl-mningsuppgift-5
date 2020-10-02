using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using SharedLibraries.Services;
using System;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace DeviceApp
{
    class Program
    {     

        static void Main(string[] args)
        {
            var device = new DeviceClientService("HostName=ec-win-iothub.azure-devices.net;DeviceId=uppgift5;SharedAccessKey=rHTQYA3LzuNz5TKif48ZSN9qocyj1yRsnekEFZ+HJl0=");

            device.SendMessagAsync().GetAwaiter();            
            Console.ReadKey();            
        }
            

       
    }
}
