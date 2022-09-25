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
        UnitManager unitManager=new UnitManager(new EfUnitDal());
        public IActionResult Index()
        {
            var values=unitManager.TGetListAll();
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
                unitManager.TInsert(unit);
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
            var value = unitManager.TGetByID(id);
            unitManager.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
