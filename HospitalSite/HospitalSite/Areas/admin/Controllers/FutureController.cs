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
    public class FutureController : Controller
    {
        private readonly AppDbContext _context;

        public FutureController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Futures.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Future model)
        {
            if (ModelState.IsValid)
            {
                _context.Futures.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Futures.Find(Id) != null)
                {
                    return View(_context.Futures.Find(Id));
                }
                else
                {
                    TempData["FutureError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FutureError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(Future model)
        {
            if (ModelState.IsValid)
            {
                _context.Futures.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Future future = _context.Futures.Find(Id);

                if (future != null)
                {
                    _context.Futures.Remove(future);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["FutureError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["FutureError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
