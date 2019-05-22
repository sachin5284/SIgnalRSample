using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace SignalRClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:8080");
            var hubProxy = hubConnection.CreateHubProxy("haulPlanHub");
            await hubConnection.Start();
            await hubProxy.Invoke("ReportEngineCompletion",476, 0);
            
            Console.ReadLine();
        }
    }
}
