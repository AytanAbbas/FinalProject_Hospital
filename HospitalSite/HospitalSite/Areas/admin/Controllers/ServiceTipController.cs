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
    [Authorize(Roles = "SuperAdmin,Admin,Moderator")]

    public class ServiceTipController : Controller
    {
        private readonly AppDbContext _context;
        public ServiceTipController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.ServiceTips.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ServiceTip model)
        {
            if (model.Name!= null)
            {
                _context.ServiceTips.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int? id)
        {

            if (id != null)
            {
                if (_context.ServiceTips.Find(id) != null)
                {
                    return View(_context.ServiceTips.Find(id));
                }
                else
                {
                    TempData["ServiceTipError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["ServiceTipError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(ServiceTip model)
        {
            if (ModelState.IsValid)
            {
                _context.ServiceTips.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                ServiceTip tip = _context.ServiceTips.Find(id);

                if (tip != null)
                {
                    _context.ServiceTips.Remove(tip);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ServiceTipError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ServiceTipError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
