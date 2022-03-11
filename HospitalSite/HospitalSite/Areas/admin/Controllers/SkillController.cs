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
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;
        public SkillController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.Skills.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Skill model)
        {
            if (model.Name != null && model.Percent != null)
            {
                _context.Skills.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                if (_context.Skills.Find(id) != null)
                {
                    return View(_context.Skills.Find(id));
                }
                else
                {
                    TempData["SkillError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["SkillError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Skill model)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Skill skill = _context.Skills.Find(id);

                if (skill != null)
                {
                    _context.Skills.Remove(skill);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["SkillError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["SkillError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
