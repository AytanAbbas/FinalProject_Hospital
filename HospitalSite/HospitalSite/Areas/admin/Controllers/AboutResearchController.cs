using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{

    [Area("Admin")]
    public class AboutResearchController : Controller
    {
        private readonly AppDbContext _context;

        public AboutResearchController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.AboutResearches.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AboutResearch model)
        {
            if (ModelState.IsValid)
            {
                _context.AboutResearches.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.AboutResearches.Find(Id) != null)
                {
                    return View(_context.AboutResearches.Find(Id));
                }
                else
                {
                    TempData["ResearchError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ResearchError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(AboutResearch model)
        {
            if (ModelState.IsValid)
            {
                _context.AboutResearches.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                AboutResearch aboutResearch = _context.AboutResearches.Find(Id);

                if (aboutResearch != null)
                {
                    _context.AboutResearches.Remove(aboutResearch);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ResearchError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["ResearchError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
