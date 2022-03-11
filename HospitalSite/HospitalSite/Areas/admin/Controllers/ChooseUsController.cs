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
    public class ChooseUsController : Controller
        {

            private readonly AppDbContext _context;

            public ChooseUsController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View(_context.ChooseUs.ToList());
            }
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(ChooseUs model)
            {
                if (ModelState.IsValid)
                {
                    _context.ChooseUs.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }

            public IActionResult Update(int? Id)
            {
                if (Id != null)
                {
                    if (_context.ChooseUs.Find(Id) != null)
                    {
                        return View(_context.ChooseUs.Find(Id));
                    }
                    else
                    {
                        TempData["ChooseUsError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["ChooseUsError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }


            }

            [HttpPost]
            public IActionResult Update(ChooseUs model)
            {
                if (ModelState.IsValid)
                {
                    _context.ChooseUs.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }

            public IActionResult Delete(int? Id)
            {
                if (Id != null)
                {
                    ChooseUs chooseUs = _context.ChooseUs.Find(Id);

                    if (chooseUs != null)
                    {
                        _context.ChooseUs.Remove(chooseUs);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["ChooseUsError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }

                }
                else
                {
                    TempData["ChooseUsError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }



            }
        }
    
}
