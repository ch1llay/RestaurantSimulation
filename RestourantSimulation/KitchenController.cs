using Microsoft.AspNetCore.Mvc;

namespace RestourantSimulation;

public class KitchenController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}