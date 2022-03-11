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

    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
    public class FidSectionController : Controller
    {
        private readonly AppDbContext _context;

        public FidSectionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.FidSections.ToList());
        }                  

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FidSection model)
        {
            if (ModelState.IsValid)
            {
                _context.FidSections.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.FidSections.Find(Id) != null)
                {
                    return View(_context.FidSections.Find(Id));
                }
                else
                {
                    TempData["FidSectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FidSectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(FidSection model)
        {
            if (ModelState.IsValid)
            {
                _context.FidSections.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                FidSection fidSection = _context.FidSections.Find(Id);

                if (fidSection != null)
                {
                    _context.FidSections.Remove(fidSection);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["FidSectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["FidSectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
