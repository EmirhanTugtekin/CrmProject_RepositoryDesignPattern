using DataAccess_Layer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI_Layer.ViewComponents.Dashboard
{
    public class Chart : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.product1 = c.Products.Where(x => x.Id == 1).Select(y => y.Stock).FirstOrDefault();
            ViewBag.product2 = c.Products.Where(x => x.Id == 2).Select(y => y.Stock).FirstOrDefault();
            ViewBag.product3 = c.Products.Where(x => x.Id == 3).Select(y => y.Stock).FirstOrDefault();
            ViewBag.product4 = c.Products.Where(x => x.Id == 4).Select(y => y.Stock).FirstOrDefault();
            ViewBag.product5 = c.Products.Where(x => x.Id == 6).Select(y => y.Stock).FirstOrDefault();
            
            return View();
        }
    }
}
