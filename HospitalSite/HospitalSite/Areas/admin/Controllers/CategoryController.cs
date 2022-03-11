using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
        [Area("Admin")]
        public class CategoryController : Controller
        {

            private readonly AppDbContext _context;

            public CategoryController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View(_context.Categories.ToList());
            }
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Category model)
            {
                if (model.Name != null )
                {
                    _context.Categories.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            TempData["CategoryError"] = "Id must not be null";
            return View(model);
            }

            public IActionResult Update(int? Id)
            {
                if (Id != null)
                {
                    if (_context.Categories.Find(Id) != null)
                    {
                        return View(_context.Categories.Find(Id));
                    }
                    else
                    {
                        TempData["CategoryError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["CategoryError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }


            }

            [HttpPost]
            public IActionResult Update(Category model)
            {
                if (ModelState.IsValid)
                {
                    _context.Categories.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(model);
            }

            public IActionResult Delete(int? Id)
            {
                if (Id != null)
                {
                Category category = _context.Categories.Find(Id);

                    if (category != null)
                    {
                        _context.Categories.Remove(category);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["CategoryError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }

                }
                else
                {
                    TempData["CategoryError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }



            }
        }
    
}
