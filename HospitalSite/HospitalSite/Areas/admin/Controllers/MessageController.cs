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

    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.ContactUs.OrderByDescending(m => m.CreatedDate).ToList());
        }

        public IActionResult Read(int? Id)
        {
            if (Id != null)
            {
                if (_context.ContactUs.Find(Id) != null)
                {
                    return View(_context.ContactUs.Find(Id));
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                ContactUs contactUs = _context.ContactUs.Find(Id);

                if (contactUs != null)
                {
                    _context.ContactUs.Remove(contactUs);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }
    }
}