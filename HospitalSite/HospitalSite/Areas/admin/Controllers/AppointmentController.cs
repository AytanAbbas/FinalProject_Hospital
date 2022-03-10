﻿using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("Admin")]
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;

        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var appointments = _context.Appointments.Include(a => a.Teams).OrderByDescending(a => a.CreatedDate);
            return View(appointments.ToList());
        }
        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Appointment message = _context.Appointments.Find(Id);

                if (message != null)
                {
                    _context.Appointments.Remove(message);
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


        public IActionResult Confirm(int id)
        {
            Appointment app = _context.Appointments.Find(id);
            app.IsActive = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("codegroupsp@gmail.com", "Labostica Hospital");
            mail.To.Add(app.Email);
            mail.Body = "<p> Congratulations </p>";
            mail.IsBodyHtml = true;
            mail.Subject = "Successfull Reservation";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");

            smtpClient.Send(mail);

            _context.Appointments.Update(app);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       

    }

}
