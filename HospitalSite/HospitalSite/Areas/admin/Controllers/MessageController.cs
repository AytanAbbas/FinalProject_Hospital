using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin,Moderator")]

    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.ContactUs.OrderByDescending(m => m.CreatedDate).ToList());
        }

        public IActionResult Read(int? Id)
        {
            if (Id != null)
            {
                if (_context.ContactUs.Find(Id) != null)
                {
                    return View(_context.ContactUs.Find(Id));
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                ContactUs contactUs = _context.ContactUs.Find(Id);

                if (contactUs != null)
                {
                    _context.ContactUs.Remove(contactUs);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(string MailText, int? id)
        {
            ContactUs contact = _context.ContactUs.FirstOrDefault(p => p.Id == id);
            MailMessage message = new MailMessage();
            message.From = new MailAddress("codegroupsp@gmail.com", "Labostica Hospital");
            message.To.Add(contact.Email);
            message.Body = MailText;
            message.IsBodyHtml = true;
            message.Subject = "Communication";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");
            smtpClient.Send(message);

            return RedirectToAction("Index");
        }
    }
}