using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            public IActionResult Message(string name, string email, string phone, int id, string note)
            {
            VmMessage message2 = new VmMessage();

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(note) )
            {
                message2.Status = false;
                message2.Message = "Məlumatları düzgün daxil etmənizi xahiş edirik!";
                return Json(message2);
            }

            Appointment appointment = new Appointment();

             appointment.CreatedDate = DateTime.Now;
            appointment.AppointmentDate = DateTime.Now;
            appointment.Name = name;
             appointment.Email = email;
             appointment.Phone = phone;
            appointment.DoctorId = id;
            appointment.Note = note;

             _context.Appointments.Add(appointment);
             _context.SaveChanges();

            message2.Status = true;
            message2.Message = "Mesajınız üçün təşəkkür edirik!";
             return Json(message2);
            }
    }
}
