using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index( VmSearch search)
        {
            VmAllSearch model = new VmAllSearch
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "Team"),
                Teams = _context.Teams.Where(t => (search.searchData != null ? t.Fullname.Contains(search.searchData) : true) ||
                                              (search.searchData != null ? t.Position.Contains(search.searchData) : true)).ToList(),
                TeamSocials = _context.TeamSocials.ToList(),
                SkillToTeams = _context.SkillToTeams.ToList(),
                TeamExperiences = _context.TeamExperiences.ToList(),
                University = _context.Universities.FirstOrDefault()
             
            };
            model.Search = search;

            return View(model);
        }
        public IActionResult Detail(int? Id, VmSearch search)
        {

            
                if (Id != null)
                {
                    
                    if (_context.Teams.Find(Id) != null)
                    {
                        VmTeam model2 = new();
                        model2.Setting = _context.Settings.FirstOrDefault();
                        model2.Banner = _context.Banners.FirstOrDefault(b => b.Page == "TeamDetail");
                        model2.SiteSocials = _context.SiteSocials.ToList();
                        model2.TeamDetail = _context.Teams.Include(u => u.University).Include(ts => ts.TeamSocials).Include(te => te.TeamExperiences).ThenInclude(we=>we.WorkExperience).Include(st => st.SkillToTeams).ThenInclude(s=>s.Skill).FirstOrDefault(t => t.Id == Id);
                        model2.Achievements = _context.Achievements.ToList();
             
                        return View(model2);
                    }
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            

        }
    }
}