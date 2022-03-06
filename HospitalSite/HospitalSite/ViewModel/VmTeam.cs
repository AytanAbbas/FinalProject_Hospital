using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmTeam:VmLayout
    {
        public List<Team> Teams { get; set; }
        public Team TeamDetail { get; set; }
        public List<TeamSocial> TeamSocials { get; set; }
        public List<SkillToTeam> SkillToTeams { get; set; }
        public List<TeamExperience> TeamExperiences { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Skill> Skills { get; set; }
        public Banner Banner { get; set; }
        public University University { get; set; }
    }
}
