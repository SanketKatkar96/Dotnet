using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
namespace Employee;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Name()
    {
        return View();
    }
    public IActionResult Salary()
    {
        return View();
    }
}