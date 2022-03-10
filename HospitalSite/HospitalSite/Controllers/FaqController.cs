using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            VmFaq model = new VmFaq
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "Faq"),
                Faqs=_context.Faqs.ToList()

            };
            return View(model);
        }


        public IActionResult Message(string name, string email, string phone, string text)
        {
            VmMessage message1 = new VmMessage();

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(text))
            {
                message1.Status = false;
                message1.Message = "Please enter the information correctly!";
                return Json(message1);
            }

            FaqMessage faqMessage = new FaqMessage();
            faqMessage.CreatedDate = DateTime.Now;
            faqMessage.Name = name;
            faqMessage.Email = email;
            faqMessage.Phone = phone;
            faqMessage.Message = text;

            _context.FaqMessages.Add(faqMessage);
            _context.SaveChanges();

            message1.Status = true;
            message1.Message = "Thank you for your message!";
            return Json(message1);
        }

    }
}
