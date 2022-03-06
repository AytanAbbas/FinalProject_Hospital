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
        public class FaqController : Controller
        {
            private readonly AppDbContext _context;

            public FaqController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View(_context.Faqs.ToList());
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Faq model)
            {
                if (ModelState.IsValid)
                {
                    _context.Faqs.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }

            public IActionResult Update(int? Id)
            {
                if (Id != null)
                {
                    if (_context.Faqs.Find(Id) != null)
                    {
                        return View(_context.Faqs.Find(Id));
                    }
                    else
                    {
                        TempData["FaqError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["FaqError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }


            }

            [HttpPost]
            public IActionResult Update(Faq model)
            {
                if (ModelState.IsValid)
                {
                    _context.Faqs.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }

            }

            public IActionResult Delete(int? Id)
            {
                if (Id != null)
                {
                    Faq faq = _context.Faqs.Find(Id);

                    if (faq != null)
                    {
                        _context.Faqs.Remove(faq);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["FaqError"] = "Such an id does not exist";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["FaqError"] = "Id must not be null";
                    return RedirectToAction("Index");
                }
            }
        }
    }

