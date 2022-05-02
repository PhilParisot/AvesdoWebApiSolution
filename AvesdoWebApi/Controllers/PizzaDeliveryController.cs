using Microsoft.AspNetCore.Mvc;

namespace AvesdoWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaDeliveryController : ControllerBase
{
    private static readonly string[] PizzaTypes = new[]
    {
        "Neapolitan", "Sicilian", "Pepperoni", "Hawaiian"
    };

    private readonly ILogger<PizzaDeliveryController> _logger;

    public PizzaDeliveryController(ILogger<PizzaDeliveryController> logger)
    {
        _logger = logger;
    }

    // [HttpGet(Name = "GetPizzasFromOrder")]
    // public IEnumerable<Order> Get()
    // {
    // }
}
