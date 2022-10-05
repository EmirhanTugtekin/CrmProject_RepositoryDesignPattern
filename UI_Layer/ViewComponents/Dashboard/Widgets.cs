using DataAccess_Layer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI_Layer.ViewComponents.Dashboard
{
    public class Widgets : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v = c.Categories.Count();
            ViewBag.v2 = c.Products.Count();
            return View();
        }
    }
}
