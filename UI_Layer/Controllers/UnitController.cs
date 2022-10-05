using Business_Layer;
using Business_Layer.ValidationRules;
using DataAccess_Layer;
using Entity_Layer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UI_Layer.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnitService unitService;

        public UnitController(IUnitService unitService)
        {
            this.unitService = unitService;
        }

        public IActionResult Index()
        {
            var values= unitService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddUnit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUnit(Unit unit)
        {
            UnitValidator validationRules = new UnitValidator();
            ValidationResult result = validationRules.Validate(unit);
            if (result.IsValid)
            {
                unit.UnitStatus = true;
                unitService.TInsert(unit);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

            
        }
        public IActionResult DeleteUnit(int id)
        {
            var value = unitService.TGetByID(id);
            unitService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
