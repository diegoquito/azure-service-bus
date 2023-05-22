using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusTrigger
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("colatest", Connection = "AzureServiceBusConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function process mesage: {myQueueItem}");
            
        }
    }
}
