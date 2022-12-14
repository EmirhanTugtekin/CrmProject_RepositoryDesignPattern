using Entity_Layer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = user.Name + " " + user.Surname;
            ViewBag.Gender = user.Gender;
            ViewBag.Image = "/images/" + user.ImageUrl;
            ViewBag.Mail = user.Email;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> EditUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(AppUser p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.Name = p.Name;
            user.Surname=p.Surname;
            user.Gender=p.Gender;
            user.PhoneNumber = p.PhoneNumber;
            user.Email = p.Email;
            user.ImageUrl = p.ImageUrl;
            user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,p.PasswordHash);
            
            var result=await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        
        }

        //ViewModel kullanımı
        [HttpGet]
        public async Task<IActionResult> UpdateUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model = new UserEditViewModel();
            model.Name = user.Name;
            model.Surname = user.Surname;
            model.Phone = user.PhoneNumber;
            model.Email = user.Email;
            model.ImageUrl = user.ImageUrl;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Password == p.ConfirmPassword)
            {
                if (p.Image != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(p.Image.FileName);
                    var imagename = Guid.NewGuid() + extension;
                    var savelocation = resource + "/wwwroot/images/" + imagename;
                    var stream = new FileStream(savelocation, FileMode.Create);
                    await p.Image.CopyToAsync(stream);
                    user.ImageUrl = imagename;
                }
                user.Name = p.Name;
                user.Surname = p.Surname;
                user.PhoneNumber = p.Phone;
                user.Email = p.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Şifreler birbiri ile uyuşmuyor");
            }
            return View();

        }
    }
}
