using Domain.Aggregates;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class StartupController : ControllerBase
{
    private readonly ILogger<Car> _logger;

    public StartupController(ILogger<Car> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "ListCars")]
    public async Task<IReadOnlyCollection<Car>> ListCars()
    {
        return new[] { new Car() };
    }
}