using Entity_Layer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]  
        public async Task<IActionResult> Index(UserSignInModel model)
        {
            if (ModelState.IsValid)//UserSignInModel'den gelen modeller valid ise (yani kurallara uygun ise (kullanıcı adı boş geçilemez vs))
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false,true);//3.parametre: beni hatırlasın mı? 4.parametre: her yanlış girdiğinde lockout değeri 1 artsın mı
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Dashboard");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
