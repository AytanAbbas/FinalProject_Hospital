using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BannerController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Banners.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                if (_context.Banners.Find(id) != null)
                {
                    return View(_context.Banners.Find(id));
                }
                else
                {
                    TempData["BannerError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BannerError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Banner banner = _context.Banners.Find(id);

                if (banner != null)
                {
                    _context.Banners.Remove(banner);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BannerError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BannerError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

    }
}
