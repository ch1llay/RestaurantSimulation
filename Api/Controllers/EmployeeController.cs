using Common.Enums;
using Microsoft.AspNetCore.Mvc;
using Service.DI.Interfaces;
using Service.Models;
using Service.Services.Interfaces;

namespace RestaurantSimulation.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : Controller
{
    private readonly IEmployeeDbService _employeeDbService;

    public EmployeeController(IServiceManager serviceManager)
    {
        _employeeDbService = serviceManager.EmployeeDbService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(Employee employee)
    {
        return Ok(await _employeeDbService.Add(employee));
    }


    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _employeeDbService.GetAll());
    }


    [HttpGet("by-type/{employeeType}")]
    public async Task<IActionResult> GetAll(EmployeeType employeeType)
    {
        return Ok(await _employeeDbService.GetByType(employeeType));
    }
}