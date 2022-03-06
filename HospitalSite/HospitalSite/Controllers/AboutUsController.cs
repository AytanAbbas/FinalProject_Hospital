using HospitalSite.Data;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;

        public AboutUsController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "About ");
            model.Setting = _context.Settings.FirstOrDefault();
            model.Choose = _context.Chooses.FirstOrDefault();
            model.WorkProcess = _context.WorkProcesses.FirstOrDefault();
            model.SiteSocials = _context.SiteSocials.ToList();
            model.ChooseUs = _context.ChooseUs.ToList();
            model.FidSections = _context.FidSections.ToList();
            model.ProcessPlans = _context.ProcessPlans.ToList();
            model.Teams = _context.Teams.Take(6).ToList();
            model.TeamSocials = _context.TeamSocials.ToList();

            return View(model);
        }
    }
}
