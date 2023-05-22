using AzureServiceBusDemo.Models;

namespace AzureServiceBusDemo.Repositories
{
    public interface IServiceBus
    {
        Task SendMessageAsync(CarDetailsModel carDetails);
    }
}
