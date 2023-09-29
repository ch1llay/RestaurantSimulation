using Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace RestaurantSimulation.Controllers;

[ApiController]
[Route("[controller]")]
public class DrinkMenuController : Controller
{
    private readonly IDrinkDbService _drinkService;

    public DrinkMenuController(IServiceManager serviceManager)
    {
        _drinkService = serviceManager.DrinkService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(Drink drink)
    {
        return Ok(_drinkService.Add(drink));
    }
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _drinkService.GetAll());
    }

    
    [HttpGet("by-type/{drinkType}")]
    public async Task<IActionResult> GetAll(DrinkType drinkType)
    {
        return Ok(await _drinkService.GetByType(drinkType));
    }
}