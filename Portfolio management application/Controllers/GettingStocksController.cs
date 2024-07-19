using Microsoft.AspNetCore.Mvc;

namespace Portfolio_management_application.Controllers;

public class GettingStocksController : Controller
{
    // GET
    public IActionResult Index()
    {
        return new AcceptedResult();
    }
}