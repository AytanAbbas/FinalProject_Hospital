using HospitalSite.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;

        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }
        //public ActionResult Index()
        //{
        //    //var appointments = _context.Appointments.Include(a => a.Doctor).OrderByDescending(a => a.Date);
        //    return View(appointments.ToList());
        //}
    }
}
