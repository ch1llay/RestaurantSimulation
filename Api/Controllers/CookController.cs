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
    private readonly IDrinkDbService _drinkDbService;
    private readonly IDishDbService _dishDbService;


    public CookController(IServiceManager serviceManager)
    {
        _cookingService = serviceManager.CookingService;
        _drinkDbService = serviceManager.DrinkService;
        _dishDbService = serviceManager.DishDbService;
    }

    [HttpGet("drink/{id}")]
    public async Task<IActionResult> CookDrink(int id)
    {
        var drink = await _drinkDbService.GetById(id);

        if (drink == null)
        {
            return NotFound();
        }
        
        return Ok(_cookingService.PrepareDrink(drink));
    }
    
    [HttpGet("dish/{id}")]
    public async Task<IActionResult> CookDish(int id)
    {
        var dish = await _dishDbService.GetById(id);

        if (dish == null)
        {
            return NotFound();
        }
        
        return Ok(_cookingService.PrepareDish(dish));
    }
    
    [HttpPost("drink")]
    public async Task<IActionResult> CookDrink(List<int> ids)
    {
        var drinks = await _drinkDbService.GetByIds(ids);

        if (!drinks.Any())
        {
            return NotFound();
        }
        
        return Ok(_cookingService.PrepareDrinks(drinks));
    }
    
    [HttpPost("dish")]
    public async Task<IActionResult> CookDish(List<int> ids)
    {
        var dishes = await _dishDbService.GetByIds(ids);

        if (!dishes.Any())
        {
            return NotFound();
        }
        return Ok(_cookingService.PrepareDishes(dishes));
    }
}