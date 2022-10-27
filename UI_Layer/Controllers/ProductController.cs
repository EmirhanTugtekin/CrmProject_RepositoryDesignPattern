using BusinessLayer.Concrete;
using DataAccess_Layer.EntityFramework;
using DataAccess_Layer;
using Entity_Layer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Abstract;

namespace UI_Layer
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = productService.TGetListProductWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productService.TInsert(product);
            return RedirectToAction("Index");
        }
    }
}
