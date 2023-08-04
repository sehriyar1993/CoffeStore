using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using CoffeStore.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit;
using System.Data;
using X.PagedList;

namespace CoffeStore.Controllers
{
    public class AdminMailController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAl());
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterDAl());
      
        [HttpGet]
        public IActionResult AdminNewsletter()
        {
            List<SelectListItem> values1 = (from x in nm.TGetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.Email,
                                                Value = x.Email.ToString(),
                                            }).ToList();
            ViewBag.v1 = values1;
            return View();
        }
       

        [HttpPost]
        public IActionResult AdminNewsletter([FromForm] MailRequestAdmin mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ficihaciyev@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ficihaciyev@gmail.com", "qcjrvjxbbuvckfcv\r\n");
                client.Send(mimeMessage);
                client.Disconnect(true);
                // display a success message
                ViewBag.Message = "Email sent successfully.";
            }
            catch (Exception ex)
            {
                // display an error message
                ViewBag.Message = "Email failed to send: " + ex.Message;
            }

            return RedirectToAction("AdminNewsletter");
        }
        

        [HttpGet]
        public IActionResult Us()
        {
            List<SelectListItem> values1 = (from x in contactManager.TGetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.EmailAddress,
                                                Value = x.EmailAddress.ToString(),
                                            }).ToList();
            ViewBag.v1 = values1;
            return View();
        }
    

        [HttpPost]
        public IActionResult Us([FromForm] MailRequestAdmin mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ficihaciyev@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ficihaciyev@gmail.com", "qcjrvjxbbuvckfcv\r\n");
                client.Send(mimeMessage);
                client.Disconnect(true);
                // display a success message
                ViewBag.Message = "Email sent successfully.";
            }
            catch (Exception ex)
            {
                // display an error message
                ViewBag.Message = "Email failed to send: " + ex.Message;
            }

            return RedirectToAction("AdminNewsletter");
        }
        public IActionResult AdminContact(int page = 1)
        {
            var values = contactManager.TGetAll().ToPagedList();
            return View(values);
        }
    }
}
