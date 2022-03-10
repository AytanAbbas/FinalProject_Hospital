using HospitalSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Accordion> Accordions { get; set; }
        public DbSet<AboutResearch> AboutResearches { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BgImage> BgImages { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FaqMessage> FaqMessages { get; set; }

        public DbSet<Choose> Chooses { get; set; }
        public DbSet<ChooseUs> ChooseUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FidSection> FidSections { get; set; }
        public DbSet<Future> Futures { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<ProcessPlan> ProcessPlans { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<ResearchImage> ResearchImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceTip> ServiceTips { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SiteSocial> SiteSocials { get; set; }
        public DbSet<TeamSocial> TeamSocials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WorkProcess> WorkProcesses { get; set; }
        public DbSet<TeamExperience> TeamExperiences { get; set; }
        public DbSet<SkillToTeam> SkillToTeams { get; set; }
        public DbSet<ServiceAbout> ServiceAbouts { get; set; }
        public DbSet<ServiceTexnoLab> ServiceTexnoLabs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
