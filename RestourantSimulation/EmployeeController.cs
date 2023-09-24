using Microsoft.AspNetCore.Mvc;
using Models.DbModels;
using Service.Interfaces;

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
}