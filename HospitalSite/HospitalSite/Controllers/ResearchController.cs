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
    public class ResearchController : Controller
    {
        private readonly AppDbContext _context;

        public ResearchController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmResearch model = new VmResearch
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "Research"),
                Researches = _context.Researches.Include(c => c.Category).ToList(),
                ResearchImages = _context.ResearchImages.ToList(),


            };

            return View(model);
        }
        public IActionResult Detail(int? Id)
        {
            if (Id != null)
            {

                if (_context.Researches.Find(Id) != null)
                {
                    VmResearch model2 = new();
                    model2.Setting = _context.Settings.FirstOrDefault();
                    model2.Banner = _context.Banners.FirstOrDefault(b => b.Page == "ResearchDetail");
                    model2.SiteSocials = _context.SiteSocials.ToList();
                    model2.Researches = _context.Researches.Include(c => c.Category).ToList();
                    model2.ResearchDetail = _context.Researches.Include(c => c.Category).Include(ri => ri.ResearchImages).FirstOrDefault(t => t.Id == Id);



                    return View(model2);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

    }
}
