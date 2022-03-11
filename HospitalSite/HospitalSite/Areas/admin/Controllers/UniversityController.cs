using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
        [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Moderator")]

    public class UniversityController : Controller
        {

            private readonly AppDbContext _context;

            public UniversityController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View(_context.Universities.ToList());
            }
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(University model)
            {
                if (ModelState.IsValid)
                {
                    _context.Universities.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }

            public IActionResult Update(int? Id)
            {
                if (Id != null)
                {
                    if (_context.Universities.Find(Id) != null)
                    {
                        return View(_context.Universities.Find(Id));
                    }
                    else
                    {
                        TempData["UniversityError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["UniversityError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }


            }

            [HttpPost]
            public IActionResult Update(University model)
            {
                if (ModelState.IsValid)
                {
                    _context.Universities.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }

            public IActionResult Delete(int? Id)
            {
                if (Id != null)
                {
                University uni = _context.Universities.Find(Id);

                    if (uni != null)
                    {
                        _context.Universities.Remove(uni);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["UniversityError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }

                }
                else
                {
                    TempData["UniversityError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }



            }
        }
    
}
