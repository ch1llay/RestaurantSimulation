using Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace RestaurantSimulation.Controllers;

[ApiController]
[Route("[controller]")]
public class CookController : Controller
{
    private readonly ICookingService _cookingService;

    public CookController(IServiceManager serviceManager)
    {
        _cookingService = serviceManager.CookingService;
    }

    [HttpGet("drink/{id}")]
    public IActionResult CookDrink(int id)
    {
        return Ok(_cookingService.PrepareDrinks(new List<int> {id}));
    }
    
    [HttpGet("dish/{id}")]
    public IActionResult CookDish(int id)
    {
        return Ok(_cookingService.PrepareDishes(new List<int> {id}));
    }
    
    [HttpPost("drink")]
    public IActionResult CookDrink(List<int> ids)
    {
        return Ok(_cookingService.PrepareDrinks(ids));
    }
    
    [HttpPost("dish")]
    public IActionResult CookDish(List<int> ids)
    {
        return Ok(_cookingService.PrepareDishes(ids));
    }
}