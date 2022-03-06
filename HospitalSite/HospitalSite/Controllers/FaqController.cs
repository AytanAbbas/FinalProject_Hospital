using HospitalSite.Data;
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
    }
}
