using Microsoft.AspNetCore.Mvc;
using Models.Enums;
using Service.Services.Interfaces;

namespace RestourantSimulation;

[ApiController]
[Route("[controller]")]
public class MenuController : Controller
{
    private readonly IDishService _dishService;

    public MenuController(IDishService dishService)
    {
        _dishService = dishService;
    }

    [HttpGet("all")]
    public IActionResult GetMenu()
    {
        return Ok(_dishService.GetAll());
    }

    [HttpGet("all/available")]
    public IActionResult GetMenuAvailible()
    {
        return Ok(_dishService.GetAllAvailable());
    }

    [HttpGet("by-type/{type}")]
    public IActionResult GetMenuAvailable(DishType type)
    {
        return Ok(_dishService.GetAllAvailable());
    }
}