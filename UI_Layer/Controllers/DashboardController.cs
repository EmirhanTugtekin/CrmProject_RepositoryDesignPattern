using Microsoft.AspNetCore.Mvc;

namespace UI_Layer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
