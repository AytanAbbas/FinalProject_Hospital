using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("admin")]
    public class TeamSocialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamSocialController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.TeamSocials.Include(ts =>ts.Team ).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Team = _context.Teams.ToList();
         
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamSocial model)
        {
            if (ModelState.IsValid)
            {


                _context.TeamSocials.Add(model);
                _context.SaveChanges();
                ViewBag.Team = _context.Teams.ToList();
                return RedirectToAction("Index");
            }

           
            return View(model);
        }


        public IActionResult Update(int? id)
        {
            TeamSocial model = _context.TeamSocials.Include(ts=>ts.Team).FirstOrDefault(a => a.Id == id);
            ViewBag.Team = _context.Teams.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(TeamSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.TeamSocials.Update(model);
                _context.SaveChanges();
                ViewBag.Team = _context.Teams.ToList();
                return RedirectToAction("Index");
            }
           

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            TeamSocial social = _context.TeamSocials.Find(id);


            if (social == null)
            {
                ///
            }


            _context.TeamSocials.Remove(social);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}
