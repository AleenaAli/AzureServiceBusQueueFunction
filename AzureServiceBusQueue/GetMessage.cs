using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Text;

namespace AzureServiceBusQueueFunction
{
    public static class GetMessage
    {
        [FunctionName("GetMessage")]
        public static void Run([ServiceBusTrigger("ordersqueue", Connection = "ServiceBusCon")]Message myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {Encoding.UTF8.GetString(myQueueItem.Body)}");
            log.LogInformation($"myQueueItem.ContentType: {myQueueItem.ContentType}");
        }
    }
}
