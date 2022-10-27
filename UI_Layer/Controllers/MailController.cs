using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class MailController : Controller
    {//uaevdmlqmpncqjjs
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Proje Admin", "istanbulakademi111@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", p.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder=new BodyBuilder();

            bodyBuilder.TextBody = p.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject=p.Subject;
            
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com",465);
            smtpClient.Authenticate("istanbulakademi111@gmail.com", "uaevdmlqmpncqjjs");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
