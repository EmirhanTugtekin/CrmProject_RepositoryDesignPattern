using Microsoft.AspNetCore.Mvc;

namespace UI_Layer
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
