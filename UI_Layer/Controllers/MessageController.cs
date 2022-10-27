using Business_Layer.Abstract;
using DataAccess_Layer;
using Entity_Layer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public MessageController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }

        public async Task<IActionResult> Inbox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = mail.Email;
            var values = _messageService.TGetReceiverMessageList(mail.Email);
            return View(values);
        }
        public async Task<IActionResult> OutBox()
        {
            var mail = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = mail.Email;
            var values = _messageService.TGetSenderMessageList(mail.Email);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Message p)
        {
            Context c = new Context();

            var mail = await _userManager.FindByNameAsync(User.Identity.Name);

            p.ReceiverName = c.Users.Where(x=>x.Email==p.ReceiverMail).Select(y=>y.Name+" "+y.Surname).FirstOrDefault();
            p.SenderName = mail.Name + " " + mail.Surname;
            p.SenderMail=mail.Email;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            _messageService.TInsert(p);
            return RedirectToAction("OutBox");
        }
        public IActionResult MessageDetails(int id)
        {
            return View();
        }
        public async Task<IActionResult> UpdateUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }
        public async Task<IActionResult> UpdateUser(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.Phone;
            user.Email = p.Email;
            user.ImageUrl = p.ImageUrl;
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

    }
}
