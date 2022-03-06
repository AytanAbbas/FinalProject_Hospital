using HospitalSite.Data;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmService model = new VmService
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                BgImage = _context.BgImages.FirstOrDefault(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "Service"),
                ServiceAbout = _context.ServiceAbouts.FirstOrDefault(),
                ServiceTips = _context.ServiceTips.ToList(),
                Futures = _context.Futures.ToList(),
                Categories = _context.Categories.ToList(),
                ResearchImages = _context.ResearchImages.ToList(),
                Partners = _context.Partners.ToList(),
              

            };
            return View(model);
        }
    }
}
