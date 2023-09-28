using Microsoft.AspNetCore.Mvc;
using Models.Application.Items;
using Models.Enums;
using Service.Services.Interfaces;

namespace RestourantSimulation;

[ApiController]
[Route("[controller]")]
public class DrinkMenuController : Controller
{
    private readonly IDrinkService _drinkService;

    public DrinkMenuController(IDrinkService drinkService)
    {
        _drinkService = drinkService;
    }

    [HttpPost]
    public async Task<IActionResult> Add(Drink drink)
    {
        return Ok(_drinkService.Add(drink));
    }

    [HttpPost]
    public async Task<IActionResult> AddMany(List<Drink> drinks)
    {
        return Ok(await _drinkService.AddMany(drinks));
    }


    [HttpPost("get-by-ids")]
    public async Task<IActionResult> GetByIds(List<int> ids)
    {
        return Ok(await _drinkService.GetByIds(ids));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _drinkService.GetAll());
    }

    [HttpGet("all/available")]
    public async Task<IActionResult> GetAllAvailable()
    {
        return Ok(await _drinkService.GetAllAvailable());
    }

    [HttpGet("by-type/{drinkType}")]
    public async Task<IActionResult> GetAll(DrinkType drinkType)
    {
        return Ok(await _drinkService.GetByType(drinkType));
    }

    [HttpGet("by-type/{drinkType}/available")]
    public async Task<IActionResult> GetByTypeAvailable(DrinkType drinkType)
    {
        return Ok(await _drinkService.GetByTypeAvailable(drinkType));
    }


    [HttpPut]
    public async Task<IActionResult> Update(Drink drink)
    {
        return Ok(await _drinkService.Update(drink));
    }

    [HttpPut]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _drinkService.Delete(id));
    }
}