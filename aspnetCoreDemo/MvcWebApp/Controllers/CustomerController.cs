using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
namespace Customer;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
