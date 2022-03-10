using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;


        public AppointmentController(AppDbContext context)
        {
            _context = context;

        }

        public IActionResult Message(VmLayout model)
        {
            //VmMessage message2 = new VmMessage();

            //if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(note))
            //{
            //    message2.Status = false;
            //    message2.Message = "Məlumatları düzgün daxil etmənizi xahiş edirik!";
            //    return Json(message2);
            //}

            //Appointment appointment = new Appointment();

            //appointment.CreatedDate = DateTime.Now;
            //appointment.AppointmentDate = DateTime.Now;
            //appointment.Name = name;
            //appointment.Email = email;
            //appointment.Phone = phone;
            //appointment.DoctorId = id;
            //appointment.Note = note;

            //_context.Appointments.Add(appointment);
            //_context.SaveChanges();

            //message2.Status = true;
            //message2.Message = "Mesajınız üçün təşəkkür edirik!";
            //return Json(message2);

            if (ModelState.IsValid)
            {

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("codegroupsp@gmail.com", "Labostica Hospital");
                mail.To.Add(model.Appointment.Email);
                mail.Body = "<p> Congratulations </p>";
                mail.IsBodyHtml = true;
                mail.Subject = "Successfull Reservation";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");

                smtpClient.Send(mail);

                CultureInfo provider = CultureInfo.InvariantCulture;


                model.Appointment.CreatedDate = DateTime.Now;
                _context.Appointments.Add(model.Appointment);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "All section is required");
            return View(model);


        }
       

    }
}
