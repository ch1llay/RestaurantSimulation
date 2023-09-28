using Microsoft.AspNetCore.Mvc;
using Models.Application;
using Service.Services.Interfaces;

namespace RestourantSimulation;

[ApiController]
[Route("[controller]")]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> MakeOrder(Order order)
    {
        return Ok(await _orderService.MakeOrder(order));
    }
    
    
    [HttpGet("all")]
    public async Task<IActionResult> GetOrders()
    {
        return Ok(await _orderService.GetOrders());
    }
    
    
    
}