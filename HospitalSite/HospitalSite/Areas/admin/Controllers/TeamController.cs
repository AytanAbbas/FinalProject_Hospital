using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "SuperAdmin,Moderator")]

    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Teams.Include(c => c.University).Include(tb => tb.SkillToTeams).ThenInclude(t => t.Skill).Include(te => te.TeamExperiences).ThenInclude(w => w.WorkExperience).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.University = _context.Universities.ToList();
            ViewBag.Skill = _context.Skills.ToList();
            ViewBag.WorkExperience = _context.WorkExperiences.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length <= 2097152)
                    {

                        //Create Team
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.Image = fileName;
                    

                        _context.Teams.Add(model);
                        _context.SaveChanges();


                        //Create Skill to team
                        if (model.SkillToTeamsId != null && model.SkillToTeamsId.Count > 0)
                        {
                            foreach (var item in model.SkillToTeamsId)
                            {
                                SkillToTeam skillToTeam = new SkillToTeam();
                                skillToTeam.SkillId = item;
                                skillToTeam.TeamId = model.Id;
                                _context.SkillToTeams.Add(skillToTeam);
                                _context.SaveChanges();
                            }
                        }
                        //Create Experience to team
                        if (model.TeamExperiencesId != null && model.TeamExperiencesId.Count > 0)
                        {
                            foreach (var item in model.TeamExperiencesId)
                            {
                                TeamExperience teamExperience = new TeamExperience();
                                teamExperience.WorkExperienceId = item;
                                teamExperience.TeamId = model.Id;
                                _context.TeamExperiences.Add(teamExperience);
                                _context.SaveChanges();
                            }
                        }

                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        ViewBag.University = _context.Universities.ToList();
                        ViewBag.Skill = _context.Skills.ToList();
                        ViewBag.WorkExperience = _context.WorkExperiences.ToList();
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    ViewBag.University = _context.Universities.ToList();
                    ViewBag.Skill = _context.Skills.ToList();
                    ViewBag.WorkExperience = _context.WorkExperiences.ToList();
                    return View(model);
                }
            }

            ViewBag.University = _context.Universities.ToList();
            ViewBag.Skill = _context.Skills.ToList();
            ViewBag.WorkExperience = _context.WorkExperiences.ToList();
            return View(model);
        }


        public IActionResult Update(int? id)
        {
            Team model = _context.Teams.Include(ts => ts.SkillToTeams).ThenInclude(s => s.Skill).Include(te => te.TeamExperiences).ThenInclude(w => w.WorkExperience).FirstOrDefault(t => t.Id == id);
            model.SkillToTeamsId = _context.SkillToTeams.Where(ts => ts.TeamId == id).Select(a => a.SkillId).ToList();
            model.TeamExperiencesId = _context.TeamExperiences.Where(te => te.TeamId == id).Select(b => b.WorkExperienceId).ToList();
            ViewBag.University = _context.Universities.ToList();
            ViewBag.Skill = _context.Skills.ToList();
            ViewBag.WorkExperience = _context.WorkExperiences.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Team model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.Image = fileName;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            ViewBag.University = _context.Universities.ToList();
                            ViewBag.Skill = _context.Skills.ToList();
                            ViewBag.WorkExperience = _context.WorkExperiences.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.University = _context.Universities.ToList();
                        ViewBag.Skill = _context.Skills.ToList();
                        ViewBag.WorkExperience = _context.WorkExperiences.ToList();
                        return View(model);
                    }
                }


                _context.Teams.Update(model);
                _context.SaveChanges();

                //Delete old data
                List<SkillToTeam> skillToTeams = _context.SkillToTeams.Where(ts => ts.TeamId == model.Id).ToList();
                foreach (var item in skillToTeams)
                {
                    _context.SkillToTeams.Remove(item);
                }
                _context.SaveChanges();

                //Create new Skill to team
                if (model.SkillToTeamsId != null && model.SkillToTeamsId.Count > 0)
                {
                    foreach (var item in model.SkillToTeamsId)
                    {
                        SkillToTeam skillToTeam = new SkillToTeam();
                        skillToTeam.SkillId = item;
                        skillToTeam.TeamId = model.Id;
                        _context.SkillToTeams.Add(skillToTeam);
                    }

                    _context.SaveChanges();
                }
                return RedirectToAction("Index");

                //Delete old data
                 List<TeamExperience> teamExperiences = _context.TeamExperiences.Where(te => te.TeamId == model.Id).ToList();
                foreach (var item in teamExperiences)
                {
                    _context.TeamExperiences.Remove(item);
                }
                _context.SaveChanges();

                //Create new Experience to team
                if (model.TeamExperiencesId != null && model.TeamExperiencesId.Count > 0)
                {
                    foreach (var item in model.TeamExperiencesId)
                    {
                        TeamExperience teamExperience = new TeamExperience();
                        teamExperience.WorkExperienceId = item;
                        teamExperience.TeamId = model.Id;
                        _context.TeamExperiences.Add(teamExperience);
                    }

                    _context.SaveChanges();
                }
                return RedirectToAction("Index");

            }

            ViewBag.University = _context.Universities.ToList();
            ViewBag.Skill = _context.Skills.ToList();
            ViewBag.WorkExperience = _context.WorkExperiences.ToList();
            return View(model);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Team team = _context.Teams.Find(id);

            if (team == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(team.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", team.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            

            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult TeamDetail(int? Id)
        {
            if (Id != null)
            {
                VmTeam model2 = new();
                if (_context.Teams.Find(Id) != null)
                {
                    model2.TeamDetail = _context.Teams.Include(u => u.University).Include(ts => ts.SkillToTeams).ThenInclude(s => s.Skill).Include(te => te.TeamExperiences).ThenInclude(w => w.WorkExperience).FirstOrDefault(t => t.Id == Id);
                    model2.University = _context.Universities.FirstOrDefault();
                    model2.Skills = _context.Skills.ToList();
                    model2.WorkExperiences = _context.WorkExperiences.ToList();
                    model2.TeamSocials = _context.TeamSocials.ToList();


                    return View(model2);
                }
                else
                {
                    TempData["TeamError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["TeamError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }


    }
}
