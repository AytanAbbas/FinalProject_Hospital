using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("admin")]
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Subscribes.ToList());
        }

        public IActionResult SendMailAll()
        {
            return View(_context.Subscribes.ToList());
        }

        [HttpPost]
        public IActionResult SendMailAll(string MailText)
        {
            List<Subscribe> subscribes = _context.Subscribes.ToList();

            foreach (var item in subscribes)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("codegroupsp@gmail.com", "Labostica");
                mail.To.Add(item.Email);
                mail.Body = MailText;
                mail.IsBodyHtml = true;
                mail.Subject = "Announcement";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");
                smtpClient.Send(mail);
            }

            return RedirectToAction("Index");
        }
    }
}

