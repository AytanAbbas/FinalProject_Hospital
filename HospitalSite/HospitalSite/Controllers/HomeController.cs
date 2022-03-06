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
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
      
        public HomeController(AppDbContext context )
        {
            _context = context;
         
        }
        public IActionResult Index()
        {
            VmHome model = new VmHome
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                HomeSliders=_context.HomeSliders.ToList(),
                Futures=_context.Futures.ToList(),
                Service=_context.Services.FirstOrDefault(),
                ServiceTips=_context.ServiceTips.ToList(),
                BgImage=_context.BgImages.FirstOrDefault(),
                Researches = _context.Researches.ToList(),
                Testimonials =_context.Testimonials.ToList(),
                Partners=_context.Partners.ToList(),
                Accordions=_context.Accordions.ToList(),
                FidSections=_context.FidSections.ToList(),
                ProcessPlans=_context.ProcessPlans.ToList(),
                Categories = _context.Categories.ToList(),
                AboutResearches =_context.AboutResearches.ToList()
              
                
            };
            return View(model);
        }
        public IActionResult Subscribe(string email)
        {
            VmSubscribeResponse response = new VmSubscribeResponse();

            if (string.IsNullOrEmpty(email))
            {
                response.Status = false;
                response.Message = "Subscribtion failed! You must enter your email";
                return Json(response);
            }

            bool isExist = _context.Subscribes.Any(s => s.Email == email);

            if (isExist)
            {
                response.Status = false;
                response.Message = "Your email have already subscribed!";
                return Json(response);
            }

            Subscribe subscribe = new Subscribe();
            subscribe.CreatedDate = DateTime.Now;
            subscribe.Email = email;
            _context.Subscribes.Add(subscribe);
            _context.SaveChanges();

            response.Status = true;
            response.Message = "Your subscribe successfully!";
            return Json(response);
        }
    }
}
