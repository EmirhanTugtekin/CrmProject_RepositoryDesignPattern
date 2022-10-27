using Entity_Layer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class Login2Controller : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        public Login2Controller(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(model.Username);
                if(await _userManager.IsLockedOutAsync(user))
                {
                    ModelState.AddModelError("", "Hesabınız geçici olarak kapatılmıştır");
                    return View();
                }
                var result = await _signInManager.PasswordSignInAsync(user, model.Password,false,true);
                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(user);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    await _userManager.AccessFailedAsync(user);
                    int failedCounter = await _userManager.GetAccessFailedCountAsync(user);
                    ModelState.AddModelError("", $"Kalan başarısız giriş hakkınız: {failedCounter}");
                    if(failedCounter == 3)
                    {
                        await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddHours(5)));
                    }    
                }

            }
            else
            {
                //ModelState.AddModelError("", "Lütfen kullanıcı adı veya şifreyi düzgün girin");
            }

            return View();
        }
    }
}
