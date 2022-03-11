using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "SuperAdmin,Moderator")]
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;
        public ExperienceController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.WorkExperiences.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WorkExperience model)
        {
            if (model.Title != null && model.Title != null && model.About != null)
            {
                _context.WorkExperiences.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                if (_context.WorkExperiences.Find(id) != null)
                {
                    return View(_context.WorkExperiences.Find(id));
                }
                else
                {
                    TempData["WorkExperienceError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["WorkExperienceError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(WorkExperience model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkExperiences.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                WorkExperience work = _context.WorkExperiences.Find(id);

                if (work != null)
                {
                    _context.WorkExperiences.Remove(work);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["WorkExperienceError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["WorkExperienceError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
