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
    public class PartnerController : Controller
    {
        private readonly AppDbContext _context;

        public PartnerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Partners.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Partner model)
        {
            if (ModelState.IsValid)
            {
                _context.Partners.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Partners.Find(Id) != null)
                {
                    return View(_context.Partners.Find(Id));
                }
                else
                {
                    TempData["PartnerError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["PartnerError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(Partner model)
        {
            if (ModelState.IsValid)
            {
                _context.Partners.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Partner partner = _context.Partners.Find(Id);

                if (partner != null)
                {
                    _context.Partners.Remove(partner);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["PartnerError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["PartnerError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
