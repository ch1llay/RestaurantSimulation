using Microsoft.AspNetCore.Mvc;
using Models.Application;
using Models.Application.Items;
using Models.Enums;
using Service.DI.Interfaces;
using Service.Services.Interfaces;

namespace RestourantSimulation;

[ApiController]
[Route("[controller]")]
public class EmployeeController : Controller
{

    private IEmployeeService _employeeService;
    
    public EmployeeController(IServiceManager serviceManager)
    {
        _employeeService = serviceManager.EmployeeService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(Employee employee)
    {
        return Ok(await _employeeService.Add(employee));
    }
    
    [HttpPost]
    public async Task<IActionResult> AddMany(List<Employee> employeees)
    {
        return Ok(await _employeeService.AddMany(employeees));
    }
    
    
    [HttpPost("get-by-ids")]
    public async Task<IActionResult> GetByIds(List<int> ids)
    {
        return Ok(await _employeeService.GetByIds(ids));
    }
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _employeeService.GetAll());
    }
    [HttpGet("all/available")]
    public async Task<IActionResult> GetAllAvailable()
    {
        return Ok(await _employeeService.GetAllAvailable());
    }
    
    [HttpGet("by-type/{employeeType}")]
    public async Task<IActionResult> GetAll(EmployeeType employeeType)
    {
        return Ok(await _employeeService.GetByType(employeeType));
    }
    
    [HttpGet("by-type/{employeeType}/available")]
    public async Task<IActionResult> GetByTypeAvailable(EmployeeType employeeType)
    {
        return Ok(await _employeeService.GetByTypeAvailable(employeeType));
    }
    
    
    [HttpPut]
    public async Task<IActionResult> Update(Employee employee)
    {
        return Ok(await _employeeService.Update(employee));
    }
    
    [HttpPut]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _employeeService.Delete(id));
    }
    
    
}