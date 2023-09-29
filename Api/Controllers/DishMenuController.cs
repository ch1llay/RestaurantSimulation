using Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace RestaurantSimulation.Controllers;

[ApiController]
[Route("[controller]")]
public class DishMenuController : Controller
{
    private readonly IDishDbService _dishDbService;

    public DishMenuController(IServiceManager serviceManager)
    {
        _dishDbService = serviceManager.DishDbService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(Dish dish)
    {
        return Ok(await _dishDbService.Add(dish));
    }


    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _dishDbService.GetAll());
    }

    [HttpGet("by-type/{dishType}")]
    public async Task<IActionResult> GetAll(DishType dishType)
    {
        return Ok(await _dishDbService.GetByType(dishType));
    }
}