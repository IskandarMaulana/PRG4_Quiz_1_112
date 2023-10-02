using Microsoft.AspNetCore.Mvc;

namespace PRG4_Quiz_1_112.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
