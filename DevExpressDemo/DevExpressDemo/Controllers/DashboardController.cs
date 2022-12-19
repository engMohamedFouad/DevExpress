using Microsoft.AspNetCore.Mvc;

namespace DevExpressDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
