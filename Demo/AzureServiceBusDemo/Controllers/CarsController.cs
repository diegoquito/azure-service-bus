using AzureServiceBusDemo.Models;
using AzureServiceBusDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AzureServiceBusDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IServiceBus _serviceBus;
        public CarsController(IServiceBus serviceBus)
        {
            _serviceBus = serviceBus;
        }

        [HttpPost("OrderDetails")]
        public async Task<IActionResult> OrderDetails(CarDetailsModel carDetails)
        {
            if (carDetails != null)
            {
                await _serviceBus.SendMessageAsync(carDetails);
            }
            return Ok();
        }
    }
}
