using Microsoft.AspNetCore.Mvc;
using Models.Domain;
using Service.Services.Interfaces;

namespace RestourantSimulation;

[ApiController]
public class EmployeeController : Controller
{
    private readonly IEmployeeService employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }

    [HttpPost("employee")]
    public async Task<IActionResult> Add(DbEmployee employee)
    {
        return Ok(await employeeService.Add(employee));
    }

    [HttpPost("employee/many")]
    public async Task<IActionResult> AddMany(List<DbEmployee> employee)
    {
        return Ok(await employeeService.AddRange(employee));
    }

    [HttpGet("employee/all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await employeeService.GetAll());
    }
}